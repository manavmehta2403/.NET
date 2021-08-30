#pragma once
#include "MainPage.g.h"

// Note: Remove this static_assert after copying these generated source files to your project.
// This assertion exists to avoid compiling these generated source files directly.
static_assert(false, "Do not compile generated C++/WinRT source files directly");

namespace winrt::SDKTemplate::implementation
{
    struct MainPage : MainPageT<MainPage>
    {
        MainPage() = default;

        static hstring FEATURE_NAME();
        static Windows::Foundation::Collections::IVector<SDKTemplate::Scenario> scenarios();
        static SDKTemplate::MainPage Current();
        void NotifyUser(hstring const& strMessage, SDKTemplate::NotifyType const& type);
        void Navigate(Windows::UI::Xaml::Interop::TypeName const& name, Windows::Foundation::IInspectable const& parameter);
    };
}
namespace winrt::SDKTemplate::factory_implementation
{
    struct MainPage : MainPageT<MainPage, implementation::MainPage>
    {
    };
}
