#pragma once
#include "Scenario4_ShowView.g.h"

// Note: Remove this static_assert after copying these generated source files to your project.
// This assertion exists to avoid compiling these generated source files directly.
static_assert(false, "Do not compile generated C++/WinRT source files directly");

namespace winrt::SDKTemplate::implementation
{
    struct Scenario4_ShowView : Scenario4_ShowViewT<Scenario4_ShowView>
    {
        Scenario4_ShowView() = default;

    };
}
namespace winrt::SDKTemplate::factory_implementation
{
    struct Scenario4_ShowView : Scenario4_ShowViewT<Scenario4_ShowView, implementation::Scenario4_ShowView>
    {
    };
}
