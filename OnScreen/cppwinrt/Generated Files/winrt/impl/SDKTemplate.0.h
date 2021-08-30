// WARNING: Please don't edit this file. It was generated by C++/WinRT v2.0.200615.7

#ifndef WINRT_SDKTemplate_0_H
#define WINRT_SDKTemplate_0_H
WINRT_EXPORT namespace winrt::Windows::Foundation::Collections
{
    template <typename T> struct __declspec(empty_bases) IVector;
}
WINRT_EXPORT namespace winrt::Windows::UI::Xaml::Interop
{
    enum class TypeKind : int32_t;
    struct TypeName;
}
WINRT_EXPORT namespace winrt::Windows::UI::Xaml::Markup
{
    struct IXamlMetadataProvider;
}
WINRT_EXPORT namespace winrt::SDKTemplate
{
    enum class NotifyType : int32_t
    {
        StatusMessage = 0,
        ErrorMessage = 1,
    };
    struct ICustomTextBox;
    struct IMainPage;
    struct IMainPageStatics;
    struct IScenario1_Launch;
    struct IScenario2_ShowHideEvents;
    struct IScenario3_ShowHideMethods;
    struct IScenario4_ShowView;
    struct CustomTextBox;
    struct MainPage;
    struct Scenario1_Launch;
    struct Scenario2_ShowHideEvents;
    struct Scenario3_ShowHideMethods;
    struct Scenario4_ShowView;
    struct XamlMetaDataProvider;
    struct Scenario;
}
namespace winrt::impl
{
    template <> struct category<SDKTemplate::ICustomTextBox>{ using type = interface_category; };
    template <> struct category<SDKTemplate::IMainPage>{ using type = interface_category; };
    template <> struct category<SDKTemplate::IMainPageStatics>{ using type = interface_category; };
    template <> struct category<SDKTemplate::IScenario1_Launch>{ using type = interface_category; };
    template <> struct category<SDKTemplate::IScenario2_ShowHideEvents>{ using type = interface_category; };
    template <> struct category<SDKTemplate::IScenario3_ShowHideMethods>{ using type = interface_category; };
    template <> struct category<SDKTemplate::IScenario4_ShowView>{ using type = interface_category; };
    template <> struct category<SDKTemplate::CustomTextBox>{ using type = class_category; };
    template <> struct category<SDKTemplate::MainPage>{ using type = class_category; };
    template <> struct category<SDKTemplate::Scenario1_Launch>{ using type = class_category; };
    template <> struct category<SDKTemplate::Scenario2_ShowHideEvents>{ using type = class_category; };
    template <> struct category<SDKTemplate::Scenario3_ShowHideMethods>{ using type = class_category; };
    template <> struct category<SDKTemplate::Scenario4_ShowView>{ using type = class_category; };
    template <> struct category<SDKTemplate::XamlMetaDataProvider>{ using type = class_category; };
    template <> struct category<SDKTemplate::NotifyType>{ using type = enum_category; };
    template <> struct category<SDKTemplate::Scenario>{ using type = struct_category<hstring, Windows::UI::Xaml::Interop::TypeName>; };
    template <> inline constexpr auto& name_v<SDKTemplate::CustomTextBox> = L"SDKTemplate.CustomTextBox";
    template <> inline constexpr auto& name_v<SDKTemplate::MainPage> = L"SDKTemplate.MainPage";
    template <> inline constexpr auto& name_v<SDKTemplate::Scenario1_Launch> = L"SDKTemplate.Scenario1_Launch";
    template <> inline constexpr auto& name_v<SDKTemplate::Scenario2_ShowHideEvents> = L"SDKTemplate.Scenario2_ShowHideEvents";
    template <> inline constexpr auto& name_v<SDKTemplate::Scenario3_ShowHideMethods> = L"SDKTemplate.Scenario3_ShowHideMethods";
    template <> inline constexpr auto& name_v<SDKTemplate::Scenario4_ShowView> = L"SDKTemplate.Scenario4_ShowView";
    template <> inline constexpr auto& name_v<SDKTemplate::XamlMetaDataProvider> = L"SDKTemplate.XamlMetaDataProvider";
    template <> inline constexpr auto& name_v<SDKTemplate::NotifyType> = L"SDKTemplate.NotifyType";
    template <> inline constexpr auto& name_v<SDKTemplate::Scenario> = L"SDKTemplate.Scenario";
    template <> inline constexpr auto& name_v<SDKTemplate::ICustomTextBox> = L"SDKTemplate.ICustomTextBox";
    template <> inline constexpr auto& name_v<SDKTemplate::IMainPage> = L"SDKTemplate.IMainPage";
    template <> inline constexpr auto& name_v<SDKTemplate::IMainPageStatics> = L"SDKTemplate.IMainPageStatics";
    template <> inline constexpr auto& name_v<SDKTemplate::IScenario1_Launch> = L"SDKTemplate.IScenario1_Launch";
    template <> inline constexpr auto& name_v<SDKTemplate::IScenario2_ShowHideEvents> = L"SDKTemplate.IScenario2_ShowHideEvents";
    template <> inline constexpr auto& name_v<SDKTemplate::IScenario3_ShowHideMethods> = L"SDKTemplate.IScenario3_ShowHideMethods";
    template <> inline constexpr auto& name_v<SDKTemplate::IScenario4_ShowView> = L"SDKTemplate.IScenario4_ShowView";
    template <> inline constexpr guid guid_v<SDKTemplate::ICustomTextBox>{ 0xBACD9719,0x01F7,0x5B59,{ 0xA3,0xB9,0x1E,0xBE,0xC1,0x9D,0x71,0xD3 } }; // BACD9719-01F7-5B59-A3B9-1EBEC19D71D3
    template <> inline constexpr guid guid_v<SDKTemplate::IMainPage>{ 0xBCD280E2,0xD1F0,0x5851,{ 0xA0,0xFA,0x4B,0xA8,0xFF,0x3A,0x26,0x32 } }; // BCD280E2-D1F0-5851-A0FA-4BA8FF3A2632
    template <> inline constexpr guid guid_v<SDKTemplate::IMainPageStatics>{ 0x42CD93B7,0xA486,0x5BB8,{ 0x81,0xA0,0xF5,0x17,0x62,0xF8,0xA1,0x6F } }; // 42CD93B7-A486-5BB8-81A0-F51762F8A16F
    template <> inline constexpr guid guid_v<SDKTemplate::IScenario1_Launch>{ 0x6E7E4584,0xC567,0x5DC7,{ 0xBF,0x57,0x01,0xB7,0xFF,0x7A,0x62,0xB0 } }; // 6E7E4584-C567-5DC7-BF57-01B7FF7A62B0
    template <> inline constexpr guid guid_v<SDKTemplate::IScenario2_ShowHideEvents>{ 0x0F9BA72D,0xE41B,0x5041,{ 0xB5,0xD5,0xC8,0x49,0xEC,0x3F,0xC5,0xA9 } }; // 0F9BA72D-E41B-5041-B5D5-C849EC3FC5A9
    template <> inline constexpr guid guid_v<SDKTemplate::IScenario3_ShowHideMethods>{ 0x072311E5,0x33AB,0x5ABA,{ 0x9D,0x59,0x21,0xC8,0xD3,0x02,0xE8,0x36 } }; // 072311E5-33AB-5ABA-9D59-21C8D302E836
    template <> inline constexpr guid guid_v<SDKTemplate::IScenario4_ShowView>{ 0x73726A62,0xB99A,0x5EAE,{ 0xBD,0xC5,0x5E,0x12,0x28,0xBF,0x5F,0xB3 } }; // 73726A62-B99A-5EAE-BDC5-5E1228BF5FB3
    template <> struct default_interface<SDKTemplate::CustomTextBox>{ using type = SDKTemplate::ICustomTextBox; };
    template <> struct default_interface<SDKTemplate::MainPage>{ using type = SDKTemplate::IMainPage; };
    template <> struct default_interface<SDKTemplate::Scenario1_Launch>{ using type = SDKTemplate::IScenario1_Launch; };
    template <> struct default_interface<SDKTemplate::Scenario2_ShowHideEvents>{ using type = SDKTemplate::IScenario2_ShowHideEvents; };
    template <> struct default_interface<SDKTemplate::Scenario3_ShowHideMethods>{ using type = SDKTemplate::IScenario3_ShowHideMethods; };
    template <> struct default_interface<SDKTemplate::Scenario4_ShowView>{ using type = SDKTemplate::IScenario4_ShowView; };
    template <> struct default_interface<SDKTemplate::XamlMetaDataProvider>{ using type = Windows::UI::Xaml::Markup::IXamlMetadataProvider; };
    template <> struct abi<SDKTemplate::ICustomTextBox>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
        };
    };
    template <> struct abi<SDKTemplate::IMainPage>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall NotifyUser(void*, int32_t) noexcept = 0;
            virtual int32_t __stdcall Navigate(struct struct_Windows_UI_Xaml_Interop_TypeName, void*) noexcept = 0;
        };
    };
    template <> struct abi<SDKTemplate::IMainPageStatics>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_FEATURE_NAME(void**) noexcept = 0;
            virtual int32_t __stdcall get_scenarios(void**) noexcept = 0;
            virtual int32_t __stdcall get_Current(void**) noexcept = 0;
        };
    };
    template <> struct abi<SDKTemplate::IScenario1_Launch>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
        };
    };
    template <> struct abi<SDKTemplate::IScenario2_ShowHideEvents>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
        };
    };
    template <> struct abi<SDKTemplate::IScenario3_ShowHideMethods>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
        };
    };
    template <> struct abi<SDKTemplate::IScenario4_ShowView>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
        };
    };
    template <typename D>
    struct consume_SDKTemplate_ICustomTextBox
    {
    };
    template <> struct consume<SDKTemplate::ICustomTextBox>
    {
        template <typename D> using type = consume_SDKTemplate_ICustomTextBox<D>;
    };
    template <typename D>
    struct consume_SDKTemplate_IMainPage
    {
        WINRT_IMPL_AUTO(void) NotifyUser(param::hstring const& strMessage, SDKTemplate::NotifyType const& type) const;
        WINRT_IMPL_AUTO(void) Navigate(Windows::UI::Xaml::Interop::TypeName const& name, Windows::Foundation::IInspectable const& parameter) const;
    };
    template <> struct consume<SDKTemplate::IMainPage>
    {
        template <typename D> using type = consume_SDKTemplate_IMainPage<D>;
    };
    template <typename D>
    struct consume_SDKTemplate_IMainPageStatics
    {
        [[nodiscard]] WINRT_IMPL_AUTO(hstring) FEATURE_NAME() const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Foundation::Collections::IVector<SDKTemplate::Scenario>) scenarios() const;
        [[nodiscard]] WINRT_IMPL_AUTO(SDKTemplate::MainPage) Current() const;
    };
    template <> struct consume<SDKTemplate::IMainPageStatics>
    {
        template <typename D> using type = consume_SDKTemplate_IMainPageStatics<D>;
    };
    template <typename D>
    struct consume_SDKTemplate_IScenario1_Launch
    {
    };
    template <> struct consume<SDKTemplate::IScenario1_Launch>
    {
        template <typename D> using type = consume_SDKTemplate_IScenario1_Launch<D>;
    };
    template <typename D>
    struct consume_SDKTemplate_IScenario2_ShowHideEvents
    {
    };
    template <> struct consume<SDKTemplate::IScenario2_ShowHideEvents>
    {
        template <typename D> using type = consume_SDKTemplate_IScenario2_ShowHideEvents<D>;
    };
    template <typename D>
    struct consume_SDKTemplate_IScenario3_ShowHideMethods
    {
    };
    template <> struct consume<SDKTemplate::IScenario3_ShowHideMethods>
    {
        template <typename D> using type = consume_SDKTemplate_IScenario3_ShowHideMethods<D>;
    };
    template <typename D>
    struct consume_SDKTemplate_IScenario4_ShowView
    {
    };
    template <> struct consume<SDKTemplate::IScenario4_ShowView>
    {
        template <typename D> using type = consume_SDKTemplate_IScenario4_ShowView<D>;
    };
    struct struct_SDKTemplate_Scenario
    {
        void* Title;
        struct{ void* Name; int32_t Kind; } ClassName;
    };
    template <> struct abi<SDKTemplate::Scenario>
    {
        using type = struct_SDKTemplate_Scenario;
    };
}
#endif
