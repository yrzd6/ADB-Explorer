﻿using ADB_Explorer.Models;
using ADB_Explorer.ViewModels;

namespace ADB_Explorer.Resources;

public static class Strings
{
    public const string S_CC_NAME = "Creative Commons";
    public const string S_APACHE_NAME = "Apache";
    public const string S_ANDROID_ROBOT_LIC = "The Android robot is reproduced or modified from work created and shared by Google and used according to terms described in the Creative Commons 3.0 Attribution License.";
    public const string S_APK_ICON_LIC = "The APK icon is licensed under the Apache License, Version 2.0.";
    public const string S_ANDROID_ICONS_TITLE = "The Android Robot Icon(s)";
    public const string S_DISABLE_ANIMATION = "The app has many animations that are enabled as part of the fluent design.\nThe side views animation is always disabled when the app window is maximized on a secondary display.\n\n• Checking this setting disables all app animations except progress bars, progress rings, and drive usage bars.";
    public const string S_ANIMATION_TITLE = "App Animations";
    public const string S_MISSING_ADB_OVERRIDE = "Could not get ADB version from provided path.";
    public const string S_ADB_VERSION_LOW_OVERRIDE = "ADB version from provided path is too low.";
    public const string S_FAIL_OVERRIDE_TITLE = "Fail to override ADB";
    public const string S_OVERRIDE_ADB_BROWSE = "Select ADB Executable";
    public const string S_RESET_SETTINGS = "All app settings will be reset upon closing the app.\nThis cannot be undone. Are you sure?";
    public const string S_RESET_SETTINGS_TITLE = "Reset App Settings";
    public const string S_NEW_VERSION_TITLE = "New App Version";
    public const string S_NAV_ERR_TITLE = "Navigation Error";
    public const string S_COPY_APK_NAME = "Copy Package Name";
    public const string S_COPY_PATH = "Copy Item Path";
    public const string S_RESTORE_ALL = "Restore All Items";
    public const string S_EMPTY_TRASH = "Empty Recycle Bin";
    public const string S_DELETE_ACTION = "Delete";
    public const string S_DEST_ERR = "Destination Path Error";
    public const string S_FAILED_CONN = "failed to connect to ";
    public const string S_FAILED_CONN_TITLE = "Connection Error";
    public const string S_DISCONN_FAILED_TITLE = "Disconnection Error";
    public const string S_PAIR_ERR_TITLE = "Pairing Error";
    public const string S_ROOT_FORBID = "Root access cannot be enabled on selected device.";
    public const string S_ROOT_FORBID_TITLE = "Root Access";
    public const string S_DEL_CONF_TITLE = "Confirm Delete";
    public const string S_PERM_DEL = "Permanently Delete";
    public const string S_CREATE_ERR_TITLE = "Create Error";
    public const string S_RESTORE_CONF_TITLE = "Restore Conflicts";
    public const string S_CONF_UNI_TITLE = "Confirm Uninstall";
    public const string S_INSTALL_APK = "Select packages to install";
    public const string S_REM_EMU = "Kill Emulator";
    public const string S_REM_HIST_DEV = "Remove Device";
    public const string S_REM_DEV = "Disconnect Device";
    public const string S_FILE_OP_TOOLTIP = "File Operations";
    public const string S_PUSH_PKG = "Install Packages";
    public const string S_NEW_DEVICE_TIP = "Pair and/or connect a WiFi device (without using mDNS)";
    public const string S_RESTART_APP = "Restart app for changes to take effect";
    public const string S_READ_FILE_ERROR_TITLE = "Error Reading File";
    public const string S_READ_FILE_ERROR = "Could not pull file in order to read it.";
    public const string S_WRITE_FILE_ERROR_TITLE = "Error Writing File";
    public const string S_WRITE_FILE_ERROR = "Could not push file back to device.";
    public const string S_DISABLE_MDNS = "ADB server needs to be restarted in order to disable mDNS.";
    public const string S_DISABLE_MDNS_TITLE = "Disable mDNS";
    public const string S_WSA_PKG_TIP = "Launch WSA in background";
    public const string S_WSA_LAUNCH = "Select Launch if ADB is already authorized in WSA.\nTo approve ADB, open WSA advanced settings.";
    public const string S_PULL_ACTION = "Pull";
    public const string S_PULL_ACTION_LINK = "Pull (Link Target)";
    public const string S_RESTORE_ACTION = "Restore";
    public const string S_DISK_USAGE_PROGRESS = "Push/pull progress is displayed in total bytes transferred.\nPercentage is available only when total size is known.";
    public const string S_DEPLOY_REDIRECTION_TITLE = "Deploy AdbProgressRedirection.exe";
    public const string S_DISK_USAGE_PROGRESS_TITLE = "Disk Usage Only";
    public const string S_PROGRESS_METHOD_TITLE = "Progress Method";
    public const string S_DEPLOY_REDIRECTION_ERROR = "Unable to deploy executable.\nDisk usage progress method will be used instead.\n\n";
    public const string S_REDIRECTION = "Progress Redirection ";
    public const string S_LS_ERROR_TITLE = "List Directory Error";
    public const string S_WIN_ROOT_ILLEGAL_TITLE = "Pull To Windows Drive Root";
    public const string S_ADVANCED_DRAG = """
        Monitoring File Explorer enables the app to perform Drag / Clipboard Pull operations directly to the destination folder.

        Otherwise, Pull is performed to the app temp folder, from which File Explorer receives the file as a stream, which has to use a small buffer.
        These two added steps slow down the process significantly.

        The feature is auto-disabled for other selected file managers.
        """;
    public const string S_ADVANCED_DRAG_TITLE = "File Explorer Monitoring";
    public const string S_ADVANCED_DRAG_SPLASH = """
        Enable only if you intend to use the app with File Explorer.
        You can always change this in the settings.
        """;
    public const string S_NEW_VERSION_MSG =
        """
        Welcome to a new ADB Explorer version!
        The release notes are available on GitHub.
        """;

    public const string S_CONFLICTING_APPS_TITLE = "Conflicting Apps";

    public static string S_CONFLICTING_APPS(IEnumerable<string> apps) =>
        $"File Explorer monitoring is not available due to the following apps running:\n\n{string.Join('\n', apps)}";

    public const string S_FUSE_DRIVE_TOOLTIP = "FUSE drive." +
        "\n• Symbolic links are not supported" +
        "\n• File names cannot contain \" * / : < > ? \\ |" +
        "\n• File names are case insensitive" +
        "\n• Installation of APKs is not supported";

    public static string S_ADB_LEARN_MORE => Data.RuntimeSettings.IsAppDeployed
        ? "Learn More About ADB"
        : "Download ADB";

    public static string S_DEPLOY_REDIRECTION => $"A helper program for reading push/pull progress from ADB.\n{(Data.RuntimeSettings.IsArm
        ? "Might falsely trigger some anti-virus programs."
        : $"Copied to %LocalAppData%\\{AdbExplorerConst.APP_DATA_FOLDER}\\")}";

    public static string S_WIN_ROOT_ILLEGAL(IEnumerable<FileClass> files) => $"{files.Count()} of the selected files cannot be created under a Windows drive root.";

    public static string S_PROGRESS_METHOD_INFO() =>
        $"• {S_DEPLOY_REDIRECTION_TITLE}\n" +
        $"    {S_DEPLOY_REDIRECTION.Replace("\n", "\n    ")}\n" +
        $"\n" +
        $"• {S_DISK_USAGE_PROGRESS_TITLE}\n" +
        $"    {S_DISK_USAGE_PROGRESS.Replace("\n", "\n    ")}";

    public static string S_NEW_VERSION(Version newVersion) =>
        $"A new {Properties.Resources.AppDisplayName}, version {newVersion}, is available";

    public static string S_ITEMS_DESTINATION(bool multipleItems, FileClass singleItem) =>
        "Select destination for " + (multipleItems ? "multiple items" : singleItem.DisplayName);

    public static string S_PUSH_BROWSE_TITLE(bool isFolderPicker, string targetName)
    {
        if (!string.IsNullOrEmpty(targetName))
            targetName = $" into {targetName}";

        return $"Select {(isFolderPicker ? "folder" : "file")}s to push{targetName}";
    }

    public static string S_DELETE_CONF(bool permanent, string deletedString) =>
        $"The following will be{(permanent ? " permanently" : "")} deleted:\n{deletedString}";

    public static string S_NEW_ITEM(bool isFolder) =>
        $"New {(isFolder ? "Folder" : "File")}";

    public static string S_CONFLICT_ITEMS(int count) =>
        $"There {(count > 1 ? "are" : "is")} {count} conflicting item{(count > 1 ? "s" : "")}";

    public static string S_MERGE_REPLACE(bool merge) =>
        $"{(merge ? "Merge or " : "")}Replace";

    public static string S_REM_APK(System.Collections.IEnumerable objects)
    {
        var count = 0;
        var name = "";
        bool apk = false;

        if (objects is IEnumerable<Package> packages)
        {
            apk = true;

            count = packages.Count();
            if (count == 1)
                name = packages.First().Name;
        }
        else if (objects is IEnumerable<FileClass> files)
        {
            count = files.Count();
            if (count == 1)
                name = files.First().DisplayName;
        }
        else
            throw new ArgumentException("Only packages and files are accepted");

        var result = count > 1 ? $"{count} {(apk ? "APK" : "package")}s" : name;

        return $"The following will be removed:\n{result}";
    }

    public static string S_REM_DEVICE(DeviceViewModel device) =>
        $"Are you sure you want to {(device.Type is AbstractDevice.DeviceType.Emulator ? "kill this emulator" : "remove this device")}?";

    public static string S_REM_DEVICE_TITLE(DeviceViewModel device)
    {
        var remType = device.Type is AbstractDevice.DeviceType.Emulator ? "Kill" : "Remove";

        var name = device switch
        {
            HistoryDeviceViewModel dev when string.IsNullOrEmpty(dev.DeviceName) => dev.IpAddress,
            HistoryDeviceViewModel dev => dev.DeviceName,
            LogicalDeviceViewModel dev => dev.Name,
            _ => throw new NotImplementedException(),
        };

        return $"{remType} {name}";
    }

    public static string S_LS_ERROR(Exception e)
    {
        return $"{(string.IsNullOrEmpty(e.Message) ? "" : e.Message + "\n\n")}An error occured while trying to list the contents of this folder.\n Visible content may be incomplete.";
    }

    public static string S_PASTE_ANCESTOR(FileClass ancestor) =>
        $"{ancestor.FullName} is an ancestor of the destination folder.";
}
