// WARNING: Please don't edit this file. It was generated by C++/WinRT v2.0.200615.7

void* winrt_make_SDKTemplate_MainPage()
{
    return winrt::detach_abi(winrt::make<winrt::SDKTemplate::factory_implementation::MainPage>());
}
WINRT_EXPORT namespace winrt::SDKTemplate
{
    MainPage::MainPage() :
        MainPage(make<SDKTemplate::implementation::MainPage>())
    {
    }
    hstring MainPage::FEATURE_NAME()
    {
        return SDKTemplate::implementation::MainPage::FEATURE_NAME();
    }
    Windows::Foundation::Collections::IVector<SDKTemplate::Scenario> MainPage::scenarios()
    {
        return SDKTemplate::implementation::MainPage::scenarios();
    }
    SDKTemplate::MainPage MainPage::Current()
    {
        return SDKTemplate::implementation::MainPage::Current();
    }
}