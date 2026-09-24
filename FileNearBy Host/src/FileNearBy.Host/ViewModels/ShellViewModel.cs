using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FileNearBy.Host.ViewModels;

public sealed record ShellSection(string Name, string Description, string EmptyTitle, string EmptyMessage);

public sealed class ShellViewModel : INotifyPropertyChanged
{
    public IReadOnlyList<ShellSection> Sections { get; } = Array.AsReadOnly<ShellSection>(
    [
        new("Overview", "Your files. Your connection. Your control.",
            "A private connection starts here",
            "Sharing is off. Connecting a phone and choosing shared locations will be available in a future version."),
        new("Shared locations", "Choose exactly what your phone can access.",
            "No locations shared",
            "Your files stay private. Adding folders and managing access will be available in a future version."),
        new("Device", "A trusted connection to your phone.",
            "No phone paired",
            "Pairing and device management will be available in a future version."),
        new("Activity", "Follow your transfers and file operations.",
            "No activity yet",
            "Transfers and file operations will appear here when sharing is available."),
        new("Storage", "Keep temporary data separate from your files.",
            "No temporary data",
            "Storage controls will be available with sharing. This version does not create previews or transfer files."),
        new("Settings", "Make File Near By feel at home.",
            "File Near By · Windows host",
            "Version 0.1.0. Connection and startup preferences will be available in a future version.")
    ]);

    private ShellSection selectedSection;

    public ShellViewModel() => selectedSection = Sections[0];

    public ShellSection SelectedSection
    {
        get => selectedSection;
        set
        {
            if (value is null || value == selectedSection || !Sections.Contains(value))
                return;

            selectedSection = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(IsOverview));
        }
    }

    public bool IsOverview => SelectedSection == Sections[0];

    public string Credit => "Leon (NguyenHuuCuongK18)";

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
