using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveTypeDto;
using HR.LeaveManagement.Core.HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Profile;

public class MappingProfile : AutoMapper.Profile
{
    public MappingProfile()
    {
        #region LeaveRequest Mappings

        CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
        CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
        CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
        CreateMap<LeaveRequest, UpdateLeaveRequestDto>().ReverseMap();

        #endregion LeaveRequest Mappings

        CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        CreateMap<LeaveAllocation, CreateLeaveAllocationDto>().ReverseMap();
        CreateMap<LeaveAllocation, UpdateLeaveAllocationDto>().ReverseMap();

        CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();
    }
}