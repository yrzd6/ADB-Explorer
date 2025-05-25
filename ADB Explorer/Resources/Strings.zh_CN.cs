using ADB_Explorer.Models;
using ADB_Explorer.ViewModels;

namespace ADB_Explorer.Resources;

public static class Strings_zh_CN
{
    public const string S_CC_NAME = "知识共享";
    public const string S_APACHE_NAME = "Apache";
    public const string S_ANDROID_ROBOT_LIC = "Android 机器人是从 Google 创建和共享的作品中复制或修改的，并根据 Creative Commons Attribution 3.0 License 中描述的条款使用。";
    public const string S_APK_ICON_LIC = "APK 图标根据 Apache License，版本 2.0 获得许可。";
    public const string S_ANDROID_ICONS_TITLE = "Android 机器人 图标";
    public const string S_DISABLE_ANIMATION = "应用启用了流畅设计中的许多动画。\n当应用窗口在副显示器上最大化时，侧边视图动画始终禁用。\n\n• 勾选此设置将禁用所有动画（进度条、进度环和驱动器使用条除外）。";
    public const string S_ANIMATION_TITLE = "应用动画";
    public const string S_MISSING_ADB_OVERRIDE = "无法从指定路径获取 ADB 版本。";
    public const string S_ADB_VERSION_LOW_OVERRIDE = "指定路径的 ADB 版本过低。";
    public const string S_FAIL_OVERRIDE_TITLE = "Fail to override ADB";
    public const string S_OVERRIDE_ADB_BROWSE = "选择 ADB 可执行文件";
    public const string S_RESET_SETTINGS = "关闭应用后，所有设置将被重置。\n此操作不可逆。你确定吗？";
    public const string S_RESET_SETTINGS_TITLE = "重置应用设置";
    public const string S_NEW_VERSION_TITLE = "新的版本";
    public const string S_NAV_ERR_TITLE = "路径导航错误";
    public const string S_COPY_APK_NAME = "复制包名";
    public const string S_COPY_PATH = "复制文件路径";
    public const string S_RESTORE_ALL = "还原所有项目";
    public const string S_EMPTY_TRASH = "清空回收站";
    public const string S_DELETE_ACTION = "删除";
    public const string S_DEST_ERR = "目标路径错误";
    public const string S_FAILED_CONN = "无法连接到 ";
    public const string S_FAILED_CONN_TITLE = "连接错误";
    public const string S_DISCONN_FAILED_TITLE = "断开连接错误";
    public const string S_PAIR_ERR_TITLE = "配对错误";
    public const string S_ROOT_FORBID = "无法在所选设备上启用 Root 权限。";
    public const string S_ROOT_FORBID_TITLE = "Root 权限";
    public const string S_DEL_CONF_TITLE = "确认删除";
    public const string S_PERM_DEL = "永久删除";
    public const string S_CREATE_ERR_TITLE = "Create Error";
    public const string S_RESTORE_CONF_TITLE = "Restore Conflicts";
    public const string S_CONF_UNI_TITLE = "确认卸载";
    public const string S_INSTALL_APK = "选择要安装的包";
    public const string S_REM_EMU = "终止模拟器";
    public const string S_REM_HIST_DEV = "删除设备";
    public const string S_REM_DEV = "断开设备连接";
    public const string S_FILE_OP_TOOLTIP = "文件操作";
    public const string S_PUSH_PKG = "Install Packages";
    public const string S_NEW_DEVICE_TIP = "配对并连接 WiFi 设备（不使用 mDNS）";
    public const string S_RESTART_APP = "重启应用以使更改生效";
    public const string S_READ_FILE_ERROR_TITLE = "文件读取错误";
    public const string S_READ_FILE_ERROR = "无法拉取文件以读取内容。";
    public const string S_WRITE_FILE_ERROR_TITLE = "文件写入错误";
    public const string S_WRITE_FILE_ERROR = "无法将文件推送回设备。";
    public const string S_DISABLE_MDNS = "需要重启 ADB 服务以禁用 mDNS。";
    public const string S_DISABLE_MDNS_TITLE = "禁用 mDNS";
    public const string S_WSA_PKG_TIP = "在后台启动 WSA";
    public const string S_WSA_LAUNCH = "若 ADB 已在 WSA 中授权，请直接点击启动。\n如需授权 ADB，请打开 WSA 高级设置。";
    public const string S_PULL_ACTION = "拉取文件";
    public const string S_PULL_ACTION_LINK = "拉取文件 (Link Target)";
    public const string S_RESTORE_ACTION = "恢复";
    public const string S_DISK_USAGE_PROGRESS = "推送/拉取进度以传输的总字节数显示。\n只有在知道总大小时才会显示百分比进度。"; 
    public const string S_DEPLOY_REDIRECTION_TITLE = "部署 AdbProgressRedirection.exe";
    public const string S_DISK_USAGE_PROGRESS_TITLE = "Disk Usage Only";
    public const string S_PROGRESS_METHOD_TITLE = "进度显示方式";
    public const string S_DEPLOY_REDIRECTION_ERROR = "无法部署可执行文件。\n将改用磁盘使用量进度显示方式。\n\n";
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
        欢迎来到 ADB Explorer 的新版本！
        发行说明已在 Github 上发布。
        """;

    public const string S_CONFLICTING_APPS_TITLE = "冲突的应用程序";

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
        $"{Properties.Resources.AppDisplayName} 有新版本 {newVersion} 可用";

    public static string S_ITEMS_DESTINATION(bool multipleItems, FileClass singleItem) =>
        "为 " + (multipleItems ? "多个项目" : singleItem.DisplayName) + " 选择目标文件夹";

    public static string S_PUSH_BROWSE_TITLE(bool isFolderPicker, string targetName)
    {
        if (!string.IsNullOrEmpty(targetName))
            targetName = $" into {targetName}";

        return $"Select {(isFolderPicker ? "folder" : "file")}s to push{targetName}";
    }

    public static string S_DELETE_CONF(bool permanent, string deletedString) =>
        $"以下内容将{(permanent ? "被永久" : "")}删除：\n{deletedString}";

    public static string S_NEW_ITEM(bool isFolder) =>
        $"新建{(isFolder ? "文件夹" : "文件")}";

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
