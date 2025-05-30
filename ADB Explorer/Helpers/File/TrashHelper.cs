﻿using ADB_Explorer.Models;
using ADB_Explorer.Services;
using ADB_Explorer.ViewModels;

namespace ADB_Explorer.Helpers;

internal static class TrashHelper
{
    public static void EnableRecycleButtons(IEnumerable<FileClass> fileList = null)
    {
        if (fileList is null)
            fileList = Data.DirList.FileList;

        Data.FileActions.RestoreEnabled = fileList.Any(file => file.TrashIndex is not null && !string.IsNullOrEmpty(file.TrashIndex.OriginalPath));
        Data.FileActions.DeleteEnabled = fileList.Any(item => item.Extension != AdbExplorerConst.RECYCLE_INDEX_SUFFIX);
    }

    public static void UpdateRecycledItemsCount()
    {
        var countTask = Task.Run(() => ADBService.CountRecycle(Data.DevicesObject.Current.ID));
        countTask.ContinueWith((t) =>
        {
            if (t.IsCanceled || Data.DevicesObject.Current is null)
                return;

            var count = t.Result;
            if (count < 1)
                count = FolderHelper.FolderExists(AdbExplorerConst.RECYCLE_PATH) is null ? -1 : 0;

            var trash = Data.DevicesObject.Current?.Drives.Find(d => d.Type is AbstractDrive.DriveType.Trash);
            App.Current.Dispatcher.Invoke(() => ((VirtualDriveViewModel)trash)?.SetItemsCount(count));
        });
    }

    public static Task ParseIndexersAsync() => Task.Run(() =>
    {
        Data.RecycleIndex.Clear();

        var indexers = ADBService.FindFilesInPath(Data.CurrentADBDevice.ID,
                                                  AdbExplorerConst.RECYCLE_PATH,
                                                  includeNames: ["*" + AdbExplorerConst.RECYCLE_INDEX_SUFFIX]);

        var lines = ShellFileOperation.ReadAllText(Data.CurrentADBDevice, indexers).Split(ADBService.LINE_SEPARATORS,
                                                                                          StringSplitOptions.RemoveEmptyEntries);

        lines.ToList().ForEach(line => Data.RecycleIndex.Add(new(line)));
    });

    public static void ParseIndexers()
    {
        Data.RecycleIndex.Clear();

        var indexers = ADBService.FindFilesInPath(Data.CurrentADBDevice.ID,
                                                  AdbExplorerConst.RECYCLE_PATH,
                                                  includeNames: ["*" + AdbExplorerConst.RECYCLE_INDEX_SUFFIX]);

        var lines = ShellFileOperation.ReadAllText(Data.CurrentADBDevice, indexers).Split(ADBService.LINE_SEPARATORS,
                                                                                          StringSplitOptions.RemoveEmptyEntries);

        lines.ToList().ForEach(line => Data.RecycleIndex.Add(new(line)));
    }
}
