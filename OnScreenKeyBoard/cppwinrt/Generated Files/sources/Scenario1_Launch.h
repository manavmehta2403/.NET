#pragma once
#include "Scenario1_Launch.g.h"

// Note: Remove this static_assert after copying these generated source files to your project.
// This assertion exists to avoid compiling these generated source files directly.
static_assert(false, "Do not compile generated C++/WinRT source files directly");

namespace winrt::SDKTemplate::implementation
{
    struct Scenario1_Launch : Scenario1_LaunchT<Scenario1_Launch>
    {
        Scenario1_Launch() = default;

    };
}
namespace winrt::SDKTemplate::factory_implementation
{
    struct Scenario1_Launch : Scenario1_LaunchT<Scenario1_Launch, implementation::Scenario1_Launch>
    {
    };
}
