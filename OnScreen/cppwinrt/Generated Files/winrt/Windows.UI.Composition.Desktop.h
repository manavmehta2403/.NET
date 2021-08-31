// WARNING: Please don't edit this file. It was generated by C++/WinRT v2.0.200615.7

#ifndef WINRT_Windows_UI_Composition_Desktop_H
#define WINRT_Windows_UI_Composition_Desktop_H
#include "winrt/base.h"
static_assert(winrt::check_version(CPPWINRT_VERSION, "2.0.200615.7"), "Mismatched C++/WinRT headers.");
#include "winrt/Windows.UI.Composition.h"
#include "winrt/impl/Windows.Foundation.2.h"
#include "winrt/impl/Windows.UI.Composition.2.h"
#include "winrt/impl/Windows.UI.Composition.Desktop.2.h"
namespace winrt::impl
{
    template <typename D> WINRT_IMPL_AUTO(bool) consume_Windows_UI_Composition_Desktop_IDesktopWindowTarget<D>::IsTopmost() const
    {
        bool value{};
        check_hresult(WINRT_IMPL_SHIM(Windows::UI::Composition::Desktop::IDesktopWindowTarget)->get_IsTopmost(&value));
        return value;
    }
#ifndef WINRT_LEAN_AND_MEAN
    template <typename D>
    struct produce<D, Windows::UI::Composition::Desktop::IDesktopWindowTarget> : produce_base<D, Windows::UI::Composition::Desktop::IDesktopWindowTarget>
    {
        int32_t __stdcall get_IsTopmost(bool* value) noexcept final try
        {
            typename D::abi_guard guard(this->shim());
            *value = detach_from<bool>(this->shim().IsTopmost());
            return 0;
        }
        catch (...) { return to_hresult(); }
    };
#endif
}
WINRT_EXPORT namespace winrt::Windows::UI::Composition::Desktop
{
}
namespace std
{
#ifndef WINRT_LEAN_AND_MEAN
    template<> struct hash<winrt::Windows::UI::Composition::Desktop::IDesktopWindowTarget> : winrt::impl::hash_base {};
    template<> struct hash<winrt::Windows::UI::Composition::Desktop::DesktopWindowTarget> : winrt::impl::hash_base {};
#endif
}
#endif
