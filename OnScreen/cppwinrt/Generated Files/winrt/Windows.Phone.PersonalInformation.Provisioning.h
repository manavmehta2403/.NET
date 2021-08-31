// WARNING: Please don't edit this file. It was generated by C++/WinRT v2.0.200615.7

#ifndef WINRT_Windows_Phone_PersonalInformation_Provisioning_H
#define WINRT_Windows_Phone_PersonalInformation_Provisioning_H
#include "winrt/base.h"
static_assert(winrt::check_version(CPPWINRT_VERSION, "2.0.200615.7"), "Mismatched C++/WinRT headers.");
#include "winrt/Windows.Phone.PersonalInformation.h"
#include "winrt/impl/Windows.Foundation.2.h"
#include "winrt/impl/Windows.Foundation.Collections.2.h"
#include "winrt/impl/Windows.Phone.PersonalInformation.2.h"
#include "winrt/impl/Windows.Storage.Streams.2.h"
#include "winrt/impl/Windows.Phone.PersonalInformation.Provisioning.2.h"
namespace winrt::impl
{
    template <typename D> WINRT_IMPL_AUTO(Windows::Foundation::IAsyncAction) consume_Windows_Phone_PersonalInformation_Provisioning_IContactPartnerProvisioningManagerStatics<D>::AssociateNetworkAccountAsync(Windows::Phone::PersonalInformation::ContactStore const& store, param::hstring const& networkName, param::hstring const& networkAccountId) const
    {
        void* result{};
        check_hresult(WINRT_IMPL_SHIM(Windows::Phone::PersonalInformation::Provisioning::IContactPartnerProvisioningManagerStatics)->AssociateNetworkAccountAsync(*(void**)(&store), *(void**)(&networkName), *(void**)(&networkAccountId), &result));
        return Windows::Foundation::IAsyncAction{ result, take_ownership_from_abi };
    }
    template <typename D> WINRT_IMPL_AUTO(Windows::Foundation::IAsyncAction) consume_Windows_Phone_PersonalInformation_Provisioning_IContactPartnerProvisioningManagerStatics<D>::ImportVcardToSystemAsync(Windows::Storage::Streams::IInputStream const& stream) const
    {
        void* result{};
        check_hresult(WINRT_IMPL_SHIM(Windows::Phone::PersonalInformation::Provisioning::IContactPartnerProvisioningManagerStatics)->ImportVcardToSystemAsync(*(void**)(&stream), &result));
        return Windows::Foundation::IAsyncAction{ result, take_ownership_from_abi };
    }
    template <typename D> WINRT_IMPL_AUTO(Windows::Foundation::IAsyncAction) consume_Windows_Phone_PersonalInformation_Provisioning_IContactPartnerProvisioningManagerStatics2<D>::AssociateSocialNetworkAccountAsync(Windows::Phone::PersonalInformation::ContactStore const& store, param::hstring const& networkName, param::hstring const& networkAccountId) const
    {
        void* result{};
        check_hresult(WINRT_IMPL_SHIM(Windows::Phone::PersonalInformation::Provisioning::IContactPartnerProvisioningManagerStatics2)->AssociateSocialNetworkAccountAsync(*(void**)(&store), *(void**)(&networkName), *(void**)(&networkAccountId), &result));
        return Windows::Foundation::IAsyncAction{ result, take_ownership_from_abi };
    }
    template <typename D> WINRT_IMPL_AUTO(Windows::Foundation::IAsyncAction) consume_Windows_Phone_PersonalInformation_Provisioning_IMessagePartnerProvisioningManagerStatics<D>::ImportSmsToSystemAsync(bool incoming, bool read, param::hstring const& body, param::hstring const& sender, param::async_vector_view<hstring> const& recipients, Windows::Foundation::DateTime const& deliveryTime) const
    {
        void* action{};
        check_hresult(WINRT_IMPL_SHIM(Windows::Phone::PersonalInformation::Provisioning::IMessagePartnerProvisioningManagerStatics)->ImportSmsToSystemAsync(incoming, read, *(void**)(&body), *(void**)(&sender), *(void**)(&recipients), impl::bind_in(deliveryTime), &action));
        return Windows::Foundation::IAsyncAction{ action, take_ownership_from_abi };
    }
    template <typename D> WINRT_IMPL_AUTO(Windows::Foundation::IAsyncAction) consume_Windows_Phone_PersonalInformation_Provisioning_IMessagePartnerProvisioningManagerStatics<D>::ImportMmsToSystemAsync(bool incoming, bool read, param::hstring const& subject, param::hstring const& sender, param::async_vector_view<hstring> const& recipients, Windows::Foundation::DateTime const& deliveryTime, param::async_vector_view<Windows::Foundation::Collections::IMapView<hstring, Windows::Foundation::IInspectable>> const& attachments) const
    {
        void* action{};
        check_hresult(WINRT_IMPL_SHIM(Windows::Phone::PersonalInformation::Provisioning::IMessagePartnerProvisioningManagerStatics)->ImportMmsToSystemAsync(incoming, read, *(void**)(&subject), *(void**)(&sender), *(void**)(&recipients), impl::bind_in(deliveryTime), *(void**)(&attachments), &action));
        return Windows::Foundation::IAsyncAction{ action, take_ownership_from_abi };
    }
#ifndef WINRT_LEAN_AND_MEAN
    template <typename D>
    struct produce<D, Windows::Phone::PersonalInformation::Provisioning::IContactPartnerProvisioningManagerStatics> : produce_base<D, Windows::Phone::PersonalInformation::Provisioning::IContactPartnerProvisioningManagerStatics>
    {
        int32_t __stdcall AssociateNetworkAccountAsync(void* store, void* networkName, void* networkAccountId, void** result) noexcept final try
        {
            clear_abi(result);
            typename D::abi_guard guard(this->shim());
            *result = detach_from<Windows::Foundation::IAsyncAction>(this->shim().AssociateNetworkAccountAsync(*reinterpret_cast<Windows::Phone::PersonalInformation::ContactStore const*>(&store), *reinterpret_cast<hstring const*>(&networkName), *reinterpret_cast<hstring const*>(&networkAccountId)));
            return 0;
        }
        catch (...) { return to_hresult(); }
        int32_t __stdcall ImportVcardToSystemAsync(void* stream, void** result) noexcept final try
        {
            clear_abi(result);
            typename D::abi_guard guard(this->shim());
            *result = detach_from<Windows::Foundation::IAsyncAction>(this->shim().ImportVcardToSystemAsync(*reinterpret_cast<Windows::Storage::Streams::IInputStream const*>(&stream)));
            return 0;
        }
        catch (...) { return to_hresult(); }
    };
#endif
#ifndef WINRT_LEAN_AND_MEAN
    template <typename D>
    struct produce<D, Windows::Phone::PersonalInformation::Provisioning::IContactPartnerProvisioningManagerStatics2> : produce_base<D, Windows::Phone::PersonalInformation::Provisioning::IContactPartnerProvisioningManagerStatics2>
    {
        int32_t __stdcall AssociateSocialNetworkAccountAsync(void* store, void* networkName, void* networkAccountId, void** result) noexcept final try
        {
            clear_abi(result);
            typename D::abi_guard guard(this->shim());
            *result = detach_from<Windows::Foundation::IAsyncAction>(this->shim().AssociateSocialNetworkAccountAsync(*reinterpret_cast<Windows::Phone::PersonalInformation::ContactStore const*>(&store), *reinterpret_cast<hstring const*>(&networkName), *reinterpret_cast<hstring const*>(&networkAccountId)));
            return 0;
        }
        catch (...) { return to_hresult(); }
    };
#endif
#ifndef WINRT_LEAN_AND_MEAN
    template <typename D>
    struct produce<D, Windows::Phone::PersonalInformation::Provisioning::IMessagePartnerProvisioningManagerStatics> : produce_base<D, Windows::Phone::PersonalInformation::Provisioning::IMessagePartnerProvisioningManagerStatics>
    {
        int32_t __stdcall ImportSmsToSystemAsync(bool incoming, bool read, void* body, void* sender, void* recipients, int64_t deliveryTime, void** action) noexcept final try
        {
            clear_abi(action);
            typename D::abi_guard guard(this->shim());
            *action = detach_from<Windows::Foundation::IAsyncAction>(this->shim().ImportSmsToSystemAsync(incoming, read, *reinterpret_cast<hstring const*>(&body), *reinterpret_cast<hstring const*>(&sender), *reinterpret_cast<Windows::Foundation::Collections::IVectorView<hstring> const*>(&recipients), *reinterpret_cast<Windows::Foundation::DateTime const*>(&deliveryTime)));
            return 0;
        }
        catch (...) { return to_hresult(); }
        int32_t __stdcall ImportMmsToSystemAsync(bool incoming, bool read, void* subject, void* sender, void* recipients, int64_t deliveryTime, void* attachments, void** action) noexcept final try
        {
            clear_abi(action);
            typename D::abi_guard guard(this->shim());
            *action = detach_from<Windows::Foundation::IAsyncAction>(this->shim().ImportMmsToSystemAsync(incoming, read, *reinterpret_cast<hstring const*>(&subject), *reinterpret_cast<hstring const*>(&sender), *reinterpret_cast<Windows::Foundation::Collections::IVectorView<hstring> const*>(&recipients), *reinterpret_cast<Windows::Foundation::DateTime const*>(&deliveryTime), *reinterpret_cast<Windows::Foundation::Collections::IVectorView<Windows::Foundation::Collections::IMapView<hstring, Windows::Foundation::IInspectable>> const*>(&attachments)));
            return 0;
        }
        catch (...) { return to_hresult(); }
    };
#endif
}
WINRT_EXPORT namespace winrt::Windows::Phone::PersonalInformation::Provisioning
{
    inline auto ContactPartnerProvisioningManager::AssociateNetworkAccountAsync(Windows::Phone::PersonalInformation::ContactStore const& store, param::hstring const& networkName, param::hstring const& networkAccountId)
    {
        return impl::call_factory<ContactPartnerProvisioningManager, IContactPartnerProvisioningManagerStatics>([&](IContactPartnerProvisioningManagerStatics const& f) { return f.AssociateNetworkAccountAsync(store, networkName, networkAccountId); });
    }
    inline auto ContactPartnerProvisioningManager::ImportVcardToSystemAsync(Windows::Storage::Streams::IInputStream const& stream)
    {
        return impl::call_factory<ContactPartnerProvisioningManager, IContactPartnerProvisioningManagerStatics>([&](IContactPartnerProvisioningManagerStatics const& f) { return f.ImportVcardToSystemAsync(stream); });
    }
    inline auto ContactPartnerProvisioningManager::AssociateSocialNetworkAccountAsync(Windows::Phone::PersonalInformation::ContactStore const& store, param::hstring const& networkName, param::hstring const& networkAccountId)
    {
        return impl::call_factory<ContactPartnerProvisioningManager, IContactPartnerProvisioningManagerStatics2>([&](IContactPartnerProvisioningManagerStatics2 const& f) { return f.AssociateSocialNetworkAccountAsync(store, networkName, networkAccountId); });
    }
    inline auto MessagePartnerProvisioningManager::ImportSmsToSystemAsync(bool incoming, bool read, param::hstring const& body, param::hstring const& sender, param::async_vector_view<hstring> const& recipients, Windows::Foundation::DateTime const& deliveryTime)
    {
        return impl::call_factory<MessagePartnerProvisioningManager, IMessagePartnerProvisioningManagerStatics>([&](IMessagePartnerProvisioningManagerStatics const& f) { return f.ImportSmsToSystemAsync(incoming, read, body, sender, recipients, deliveryTime); });
    }
    inline auto MessagePartnerProvisioningManager::ImportMmsToSystemAsync(bool incoming, bool read, param::hstring const& subject, param::hstring const& sender, param::async_vector_view<hstring> const& recipients, Windows::Foundation::DateTime const& deliveryTime, param::async_vector_view<Windows::Foundation::Collections::IMapView<hstring, Windows::Foundation::IInspectable>> const& attachments)
    {
        return impl::call_factory<MessagePartnerProvisioningManager, IMessagePartnerProvisioningManagerStatics>([&](IMessagePartnerProvisioningManagerStatics const& f) { return f.ImportMmsToSystemAsync(incoming, read, subject, sender, recipients, deliveryTime, attachments); });
    }
}
namespace std
{
#ifndef WINRT_LEAN_AND_MEAN
    template<> struct hash<winrt::Windows::Phone::PersonalInformation::Provisioning::IContactPartnerProvisioningManagerStatics> : winrt::impl::hash_base {};
    template<> struct hash<winrt::Windows::Phone::PersonalInformation::Provisioning::IContactPartnerProvisioningManagerStatics2> : winrt::impl::hash_base {};
    template<> struct hash<winrt::Windows::Phone::PersonalInformation::Provisioning::IMessagePartnerProvisioningManagerStatics> : winrt::impl::hash_base {};
    template<> struct hash<winrt::Windows::Phone::PersonalInformation::Provisioning::ContactPartnerProvisioningManager> : winrt::impl::hash_base {};
    template<> struct hash<winrt::Windows::Phone::PersonalInformation::Provisioning::MessagePartnerProvisioningManager> : winrt::impl::hash_base {};
#endif
}
#endif
