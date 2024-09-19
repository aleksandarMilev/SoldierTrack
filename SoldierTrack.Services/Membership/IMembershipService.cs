﻿namespace SoldierTrack.Services.Membership
{
    using SoldierTrack.Services.Membership.Models;
    using SoldierTrack.Services.Membership.Models.Base;

    public interface IMembershipService
    {
        Task RequestAsync(CreateMembershipServiceModel model);

        Task<IEnumerable<MembershipPendingServiceModel>> GetAllPendingAsync();

        Task<EditMembershipServiceModel?> GetEditModelByIdAsync(int id);

        Task<int> GetPendingCountAsync();

        Task ApproveAsync(int id);

        Task RejectAsync(int id);

        Task EditAsync(EditMembershipServiceModel serviceModel);
    }
}
