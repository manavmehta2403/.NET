// WARNING: Please don't edit this file. It was generated by C++/WinRT v2.0.200615.7

#ifndef WINRT_Windows_Storage_Pickers_0_H
#define WINRT_Windows_Storage_Pickers_0_H
WINRT_EXPORT namespace winrt::Windows::Foundation
{
    template <typename TResult> struct __declspec(empty_bases) IAsyncOperation;
}
WINRT_EXPORT namespace winrt::Windows::Foundation::Collections
{
    template <typename K, typename V> struct __declspec(empty_bases) IMap;
    template <typename T> struct __declspec(empty_bases) IVectorView;
    template <typename T> struct __declspec(empty_bases) IVector;
    struct ValueSet;
}
WINRT_EXPORT namespace winrt::Windows::Storage
{
    struct StorageFile;
    struct StorageFolder;
}
WINRT_EXPORT namespace winrt::Windows::System
{
    struct User;
}
WINRT_EXPORT namespace winrt::Windows::Storage::Pickers
{
    enum class PickerLocationId : int32_t
    {
        DocumentsLibrary = 0,
        ComputerFolder = 1,
        Desktop = 2,
        Downloads = 3,
        HomeGroup = 4,
        MusicLibrary = 5,
        PicturesLibrary = 6,
        VideosLibrary = 7,
        Objects3D = 8,
        Unspecified = 9,
    };
    enum class PickerViewMode : int32_t
    {
        List = 0,
        Thumbnail = 1,
    };
    struct IFileOpenPicker;
    struct IFileOpenPicker2;
    struct IFileOpenPicker3;
    struct IFileOpenPickerStatics;
    struct IFileOpenPickerStatics2;
    struct IFileOpenPickerWithOperationId;
    struct IFileSavePicker;
    struct IFileSavePicker2;
    struct IFileSavePicker3;
    struct IFileSavePicker4;
    struct IFileSavePickerStatics;
    struct IFolderPicker;
    struct IFolderPicker2;
    struct IFolderPicker3;
    struct IFolderPickerStatics;
    struct FileExtensionVector;
    struct FileOpenPicker;
    struct FilePickerFileTypesOrderedMap;
    struct FilePickerSelectedFilesArray;
    struct FileSavePicker;
    struct FolderPicker;
}
namespace winrt::impl
{
    template <> struct category<Windows::Storage::Pickers::IFileOpenPicker>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFileOpenPicker2>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFileOpenPicker3>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFileOpenPickerStatics>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFileOpenPickerStatics2>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFileOpenPickerWithOperationId>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFileSavePicker>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFileSavePicker2>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFileSavePicker3>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFileSavePicker4>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFileSavePickerStatics>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFolderPicker>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFolderPicker2>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFolderPicker3>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::IFolderPickerStatics>{ using type = interface_category; };
    template <> struct category<Windows::Storage::Pickers::FileExtensionVector>{ using type = class_category; };
    template <> struct category<Windows::Storage::Pickers::FileOpenPicker>{ using type = class_category; };
    template <> struct category<Windows::Storage::Pickers::FilePickerFileTypesOrderedMap>{ using type = class_category; };
    template <> struct category<Windows::Storage::Pickers::FilePickerSelectedFilesArray>{ using type = class_category; };
    template <> struct category<Windows::Storage::Pickers::FileSavePicker>{ using type = class_category; };
    template <> struct category<Windows::Storage::Pickers::FolderPicker>{ using type = class_category; };
    template <> struct category<Windows::Storage::Pickers::PickerLocationId>{ using type = enum_category; };
    template <> struct category<Windows::Storage::Pickers::PickerViewMode>{ using type = enum_category; };
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::FileExtensionVector> = L"Windows.Storage.Pickers.FileExtensionVector";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::FileOpenPicker> = L"Windows.Storage.Pickers.FileOpenPicker";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::FilePickerFileTypesOrderedMap> = L"Windows.Storage.Pickers.FilePickerFileTypesOrderedMap";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::FilePickerSelectedFilesArray> = L"Windows.Storage.Pickers.FilePickerSelectedFilesArray";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::FileSavePicker> = L"Windows.Storage.Pickers.FileSavePicker";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::FolderPicker> = L"Windows.Storage.Pickers.FolderPicker";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::PickerLocationId> = L"Windows.Storage.Pickers.PickerLocationId";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::PickerViewMode> = L"Windows.Storage.Pickers.PickerViewMode";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileOpenPicker> = L"Windows.Storage.Pickers.IFileOpenPicker";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileOpenPicker2> = L"Windows.Storage.Pickers.IFileOpenPicker2";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileOpenPicker3> = L"Windows.Storage.Pickers.IFileOpenPicker3";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileOpenPickerStatics> = L"Windows.Storage.Pickers.IFileOpenPickerStatics";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileOpenPickerStatics2> = L"Windows.Storage.Pickers.IFileOpenPickerStatics2";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileOpenPickerWithOperationId> = L"Windows.Storage.Pickers.IFileOpenPickerWithOperationId";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileSavePicker> = L"Windows.Storage.Pickers.IFileSavePicker";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileSavePicker2> = L"Windows.Storage.Pickers.IFileSavePicker2";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileSavePicker3> = L"Windows.Storage.Pickers.IFileSavePicker3";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileSavePicker4> = L"Windows.Storage.Pickers.IFileSavePicker4";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFileSavePickerStatics> = L"Windows.Storage.Pickers.IFileSavePickerStatics";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFolderPicker> = L"Windows.Storage.Pickers.IFolderPicker";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFolderPicker2> = L"Windows.Storage.Pickers.IFolderPicker2";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFolderPicker3> = L"Windows.Storage.Pickers.IFolderPicker3";
    template <> inline constexpr auto& name_v<Windows::Storage::Pickers::IFolderPickerStatics> = L"Windows.Storage.Pickers.IFolderPickerStatics";
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileOpenPicker>{ 0x2CA8278A,0x12C5,0x4C5F,{ 0x89,0x77,0x94,0x54,0x77,0x93,0xC2,0x41 } }; // 2CA8278A-12C5-4C5F-8977-94547793C241
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileOpenPicker2>{ 0x8CEB6CD2,0xB446,0x46F7,{ 0xB2,0x65,0x90,0xF8,0xE5,0x5A,0xD6,0x50 } }; // 8CEB6CD2-B446-46F7-B265-90F8E55AD650
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileOpenPicker3>{ 0xD9A5C5B3,0xC5DC,0x5B98,{ 0xBD,0x80,0xA8,0xD0,0xCA,0x05,0x84,0xD8 } }; // D9A5C5B3-C5DC-5B98-BD80-A8D0CA0584D8
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileOpenPickerStatics>{ 0x6821573B,0x2F02,0x4833,{ 0x96,0xD4,0xAB,0xBF,0xAD,0x72,0xB6,0x7B } }; // 6821573B-2F02-4833-96D4-ABBFAD72B67B
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileOpenPickerStatics2>{ 0xE8917415,0xEDDD,0x5C98,{ 0xB6,0xF3,0x36,0x6F,0xDF,0xCA,0xD3,0x92 } }; // E8917415-EDDD-5C98-B6F3-366FDFCAD392
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileOpenPickerWithOperationId>{ 0x3F57B569,0x2522,0x4CA5,{ 0xAA,0x73,0xA1,0x55,0x09,0xF1,0xFC,0xBF } }; // 3F57B569-2522-4CA5-AA73-A15509F1FCBF
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileSavePicker>{ 0x3286FFCB,0x617F,0x4CC5,{ 0xAF,0x6A,0xB3,0xFD,0xF2,0x9A,0xD1,0x45 } }; // 3286FFCB-617F-4CC5-AF6A-B3FDF29AD145
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileSavePicker2>{ 0x0EC313A2,0xD24B,0x449A,{ 0x81,0x97,0xE8,0x91,0x04,0xFD,0x42,0xCC } }; // 0EC313A2-D24B-449A-8197-E89104FD42CC
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileSavePicker3>{ 0x698AEC69,0xBA3C,0x4E51,{ 0xBD,0x90,0x4A,0xBC,0xBB,0xF4,0xCF,0xAF } }; // 698AEC69-BA3C-4E51-BD90-4ABCBBF4CFAF
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileSavePicker4>{ 0xE7D83A5A,0xDDFA,0x5DE0,{ 0x8B,0x70,0xC8,0x42,0xC2,0x19,0x88,0xEC } }; // E7D83A5A-DDFA-5DE0-8B70-C842C21988EC
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFileSavePickerStatics>{ 0x28E3CF9E,0x961C,0x5E2C,{ 0xAE,0xD7,0xE6,0x47,0x37,0xF4,0xCE,0x37 } }; // 28E3CF9E-961C-5E2C-AED7-E64737F4CE37
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFolderPicker>{ 0x084F7799,0xF3FB,0x400A,{ 0x99,0xB1,0x7B,0x4A,0x77,0x2F,0xD6,0x0D } }; // 084F7799-F3FB-400A-99B1-7B4A772FD60D
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFolderPicker2>{ 0x8EB3BA97,0xDC85,0x4616,{ 0xBE,0x94,0x96,0x60,0x88,0x1F,0x2F,0x5D } }; // 8EB3BA97-DC85-4616-BE94-9660881F2F5D
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFolderPicker3>{ 0x673B1E29,0xD326,0x53C0,{ 0xBD,0x24,0xA2,0x5C,0x71,0x4C,0xEE,0x36 } }; // 673B1E29-D326-53C0-BD24-A25C714CEE36
    template <> inline constexpr guid guid_v<Windows::Storage::Pickers::IFolderPickerStatics>{ 0x9BE34740,0x7CA1,0x5942,{ 0xA3,0xC8,0x46,0xF2,0x55,0x1E,0xCF,0xF3 } }; // 9BE34740-7CA1-5942-A3C8-46F2551ECFF3
    template <> struct default_interface<Windows::Storage::Pickers::FileExtensionVector>{ using type = Windows::Foundation::Collections::IVector<hstring>; };
    template <> struct default_interface<Windows::Storage::Pickers::FileOpenPicker>{ using type = Windows::Storage::Pickers::IFileOpenPicker; };
    template <> struct default_interface<Windows::Storage::Pickers::FilePickerFileTypesOrderedMap>{ using type = Windows::Foundation::Collections::IMap<hstring, Windows::Foundation::Collections::IVector<hstring>>; };
    template <> struct default_interface<Windows::Storage::Pickers::FilePickerSelectedFilesArray>{ using type = Windows::Foundation::Collections::IVectorView<Windows::Storage::StorageFile>; };
    template <> struct default_interface<Windows::Storage::Pickers::FileSavePicker>{ using type = Windows::Storage::Pickers::IFileSavePicker; };
    template <> struct default_interface<Windows::Storage::Pickers::FolderPicker>{ using type = Windows::Storage::Pickers::IFolderPicker; };
    template <> struct abi<Windows::Storage::Pickers::IFileOpenPicker>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_ViewMode(int32_t*) noexcept = 0;
            virtual int32_t __stdcall put_ViewMode(int32_t) noexcept = 0;
            virtual int32_t __stdcall get_SettingsIdentifier(void**) noexcept = 0;
            virtual int32_t __stdcall put_SettingsIdentifier(void*) noexcept = 0;
            virtual int32_t __stdcall get_SuggestedStartLocation(int32_t*) noexcept = 0;
            virtual int32_t __stdcall put_SuggestedStartLocation(int32_t) noexcept = 0;
            virtual int32_t __stdcall get_CommitButtonText(void**) noexcept = 0;
            virtual int32_t __stdcall put_CommitButtonText(void*) noexcept = 0;
            virtual int32_t __stdcall get_FileTypeFilter(void**) noexcept = 0;
            virtual int32_t __stdcall PickSingleFileAsync(void**) noexcept = 0;
            virtual int32_t __stdcall PickMultipleFilesAsync(void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFileOpenPicker2>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_ContinuationData(void**) noexcept = 0;
            virtual int32_t __stdcall PickSingleFileAndContinue() noexcept = 0;
            virtual int32_t __stdcall PickMultipleFilesAndContinue() noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFileOpenPicker3>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_User(void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFileOpenPickerStatics>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall ResumePickSingleFileAsync(void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFileOpenPickerStatics2>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall CreateForUser(void*, void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFileOpenPickerWithOperationId>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall PickSingleFileAsync(void*, void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFileSavePicker>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_SettingsIdentifier(void**) noexcept = 0;
            virtual int32_t __stdcall put_SettingsIdentifier(void*) noexcept = 0;
            virtual int32_t __stdcall get_SuggestedStartLocation(int32_t*) noexcept = 0;
            virtual int32_t __stdcall put_SuggestedStartLocation(int32_t) noexcept = 0;
            virtual int32_t __stdcall get_CommitButtonText(void**) noexcept = 0;
            virtual int32_t __stdcall put_CommitButtonText(void*) noexcept = 0;
            virtual int32_t __stdcall get_FileTypeChoices(void**) noexcept = 0;
            virtual int32_t __stdcall get_DefaultFileExtension(void**) noexcept = 0;
            virtual int32_t __stdcall put_DefaultFileExtension(void*) noexcept = 0;
            virtual int32_t __stdcall get_SuggestedSaveFile(void**) noexcept = 0;
            virtual int32_t __stdcall put_SuggestedSaveFile(void*) noexcept = 0;
            virtual int32_t __stdcall get_SuggestedFileName(void**) noexcept = 0;
            virtual int32_t __stdcall put_SuggestedFileName(void*) noexcept = 0;
            virtual int32_t __stdcall PickSaveFileAsync(void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFileSavePicker2>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_ContinuationData(void**) noexcept = 0;
            virtual int32_t __stdcall PickSaveFileAndContinue() noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFileSavePicker3>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_EnterpriseId(void**) noexcept = 0;
            virtual int32_t __stdcall put_EnterpriseId(void*) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFileSavePicker4>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_User(void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFileSavePickerStatics>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall CreateForUser(void*, void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFolderPicker>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_ViewMode(int32_t*) noexcept = 0;
            virtual int32_t __stdcall put_ViewMode(int32_t) noexcept = 0;
            virtual int32_t __stdcall get_SettingsIdentifier(void**) noexcept = 0;
            virtual int32_t __stdcall put_SettingsIdentifier(void*) noexcept = 0;
            virtual int32_t __stdcall get_SuggestedStartLocation(int32_t*) noexcept = 0;
            virtual int32_t __stdcall put_SuggestedStartLocation(int32_t) noexcept = 0;
            virtual int32_t __stdcall get_CommitButtonText(void**) noexcept = 0;
            virtual int32_t __stdcall put_CommitButtonText(void*) noexcept = 0;
            virtual int32_t __stdcall get_FileTypeFilter(void**) noexcept = 0;
            virtual int32_t __stdcall PickSingleFolderAsync(void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFolderPicker2>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_ContinuationData(void**) noexcept = 0;
            virtual int32_t __stdcall PickFolderAndContinue() noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFolderPicker3>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_User(void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Storage::Pickers::IFolderPickerStatics>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall CreateForUser(void*, void**) noexcept = 0;
        };
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileOpenPicker
    {
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Storage::Pickers::PickerViewMode) ViewMode() const;
        WINRT_IMPL_AUTO(void) ViewMode(Windows::Storage::Pickers::PickerViewMode const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(hstring) SettingsIdentifier() const;
        WINRT_IMPL_AUTO(void) SettingsIdentifier(param::hstring const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Storage::Pickers::PickerLocationId) SuggestedStartLocation() const;
        WINRT_IMPL_AUTO(void) SuggestedStartLocation(Windows::Storage::Pickers::PickerLocationId const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(hstring) CommitButtonText() const;
        WINRT_IMPL_AUTO(void) CommitButtonText(param::hstring const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Foundation::Collections::IVector<hstring>) FileTypeFilter() const;
        WINRT_IMPL_AUTO(Windows::Foundation::IAsyncOperation<Windows::Storage::StorageFile>) PickSingleFileAsync() const;
        WINRT_IMPL_AUTO(Windows::Foundation::IAsyncOperation<Windows::Foundation::Collections::IVectorView<Windows::Storage::StorageFile>>) PickMultipleFilesAsync() const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileOpenPicker>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileOpenPicker<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileOpenPicker2
    {
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Foundation::Collections::ValueSet) ContinuationData() const;
        WINRT_IMPL_AUTO(void) PickSingleFileAndContinue() const;
        WINRT_IMPL_AUTO(void) PickMultipleFilesAndContinue() const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileOpenPicker2>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileOpenPicker2<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileOpenPicker3
    {
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::System::User) User() const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileOpenPicker3>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileOpenPicker3<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileOpenPickerStatics
    {
        WINRT_IMPL_AUTO(Windows::Foundation::IAsyncOperation<Windows::Storage::StorageFile>) ResumePickSingleFileAsync() const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileOpenPickerStatics>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileOpenPickerStatics<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileOpenPickerStatics2
    {
        WINRT_IMPL_AUTO(Windows::Storage::Pickers::FileOpenPicker) CreateForUser(Windows::System::User const& user) const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileOpenPickerStatics2>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileOpenPickerStatics2<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileOpenPickerWithOperationId
    {
        WINRT_IMPL_AUTO(Windows::Foundation::IAsyncOperation<Windows::Storage::StorageFile>) PickSingleFileAsync(param::hstring const& pickerOperationId) const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileOpenPickerWithOperationId>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileOpenPickerWithOperationId<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileSavePicker
    {
        [[nodiscard]] WINRT_IMPL_AUTO(hstring) SettingsIdentifier() const;
        WINRT_IMPL_AUTO(void) SettingsIdentifier(param::hstring const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Storage::Pickers::PickerLocationId) SuggestedStartLocation() const;
        WINRT_IMPL_AUTO(void) SuggestedStartLocation(Windows::Storage::Pickers::PickerLocationId const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(hstring) CommitButtonText() const;
        WINRT_IMPL_AUTO(void) CommitButtonText(param::hstring const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Foundation::Collections::IMap<hstring, Windows::Foundation::Collections::IVector<hstring>>) FileTypeChoices() const;
        [[nodiscard]] WINRT_IMPL_AUTO(hstring) DefaultFileExtension() const;
        WINRT_IMPL_AUTO(void) DefaultFileExtension(param::hstring const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Storage::StorageFile) SuggestedSaveFile() const;
        WINRT_IMPL_AUTO(void) SuggestedSaveFile(Windows::Storage::StorageFile const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(hstring) SuggestedFileName() const;
        WINRT_IMPL_AUTO(void) SuggestedFileName(param::hstring const& value) const;
        WINRT_IMPL_AUTO(Windows::Foundation::IAsyncOperation<Windows::Storage::StorageFile>) PickSaveFileAsync() const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileSavePicker>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileSavePicker<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileSavePicker2
    {
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Foundation::Collections::ValueSet) ContinuationData() const;
        WINRT_IMPL_AUTO(void) PickSaveFileAndContinue() const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileSavePicker2>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileSavePicker2<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileSavePicker3
    {
        [[nodiscard]] WINRT_IMPL_AUTO(hstring) EnterpriseId() const;
        WINRT_IMPL_AUTO(void) EnterpriseId(param::hstring const& value) const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileSavePicker3>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileSavePicker3<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileSavePicker4
    {
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::System::User) User() const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileSavePicker4>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileSavePicker4<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFileSavePickerStatics
    {
        WINRT_IMPL_AUTO(Windows::Storage::Pickers::FileSavePicker) CreateForUser(Windows::System::User const& user) const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFileSavePickerStatics>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFileSavePickerStatics<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFolderPicker
    {
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Storage::Pickers::PickerViewMode) ViewMode() const;
        WINRT_IMPL_AUTO(void) ViewMode(Windows::Storage::Pickers::PickerViewMode const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(hstring) SettingsIdentifier() const;
        WINRT_IMPL_AUTO(void) SettingsIdentifier(param::hstring const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Storage::Pickers::PickerLocationId) SuggestedStartLocation() const;
        WINRT_IMPL_AUTO(void) SuggestedStartLocation(Windows::Storage::Pickers::PickerLocationId const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(hstring) CommitButtonText() const;
        WINRT_IMPL_AUTO(void) CommitButtonText(param::hstring const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Foundation::Collections::IVector<hstring>) FileTypeFilter() const;
        WINRT_IMPL_AUTO(Windows::Foundation::IAsyncOperation<Windows::Storage::StorageFolder>) PickSingleFolderAsync() const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFolderPicker>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFolderPicker<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFolderPicker2
    {
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Foundation::Collections::ValueSet) ContinuationData() const;
        WINRT_IMPL_AUTO(void) PickFolderAndContinue() const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFolderPicker2>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFolderPicker2<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFolderPicker3
    {
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::System::User) User() const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFolderPicker3>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFolderPicker3<D>;
    };
    template <typename D>
    struct consume_Windows_Storage_Pickers_IFolderPickerStatics
    {
        WINRT_IMPL_AUTO(Windows::Storage::Pickers::FolderPicker) CreateForUser(Windows::System::User const& user) const;
    };
    template <> struct consume<Windows::Storage::Pickers::IFolderPickerStatics>
    {
        template <typename D> using type = consume_Windows_Storage_Pickers_IFolderPickerStatics<D>;
    };
}
#endif
