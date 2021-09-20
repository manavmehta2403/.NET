#pragma once
#include "Scenario3_ShowHideMethods.g.h"

// Note: Remove this static_assert after copying these generated source files to your project.
// This assertion exists to avoid compiling these generated source files directly.
static_assert(false, "Do not compile generated C++/WinRT source files directly");

namespace winrt::SDKTemplate::implementation
{
    struct Scenario3_ShowHideMethods : Scenario3_ShowHideMethodsT<Scenario3_ShowHideMethods>
    {
        Scenario3_ShowHideMethods() = default;

    };
}
namespace winrt::SDKTemplate::factory_implementation
{
    struct Scenario3_ShowHideMethods : Scenario3_ShowHideMethodsT<Scenario3_ShowHideMethods, implementation::Scenario3_ShowHideMethods>
    {
    };
}
