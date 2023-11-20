using AutoMapper;
using Core;
using Core.IUnitOfWork;
using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Service
{
    public class StaffService : IStaffService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IStaffsRepository _IStaffsRepository;  //Core Katmanı
        private readonly IStaffProcessPermisionsRepository _IStaffProcessPermisionsRepository;  //Core Katmanı
        private readonly IStaffRolesRepository _IStaffRolesRepository;  //Core Katmanı
        public StaffService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IStaffsRepository IStaffsRepository,
            IStaffProcessPermisionsRepository IStaffProcessPermisionsRepository,
            IStaffRolesRepository IStaffRolesRepository
            )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _IStaffsRepository = IStaffsRepository;
            _IStaffProcessPermisionsRepository = IStaffProcessPermisionsRepository;
            _IStaffRolesRepository = IStaffRolesRepository;
        }
        public void Add(StaffDTO entitiy)
        {
            var staffMapper = _mapper.Map<Staffs>(entitiy);
            var staffProcessPermisionsMapper = _mapper.Map<List<StaffProcessPermisions>>(entitiy.StaffProcessPermisionsDTOs);
            var staffRolesMapper = _mapper.Map<List<StaffRoles>>(entitiy.StaffRolesDTO);
            staffMapper.Status = 1;
            var staff = _IStaffsRepository.Add(staffMapper);
            _unitOfWork.SaveChanges();

            StaffProcessPermisions staffProcessPermisionsList = new StaffProcessPermisions();
            foreach (var item in staffProcessPermisionsMapper)
            {
                staffProcessPermisionsList=new StaffProcessPermisions()
                {
                    StaffId = staff.Id,
                    ProcessId = item.ProcessId,
                    CreateDate = item.CreateDate,
                    UpdateDate = item.UpdateDate
                };
                _IStaffProcessPermisionsRepository.Add(staffProcessPermisionsList);
                _unitOfWork.SaveChanges();
            }
            
            

            List<StaffRoles> staffRolesList = new List<StaffRoles>();
            foreach (var item in staffRolesMapper)
            {
                staffRolesList.Add(new StaffRoles()
                {
                    StaffId = staff.Id,
                    CreateDate = item.CreateDate,
                    UpdateDate = item.UpdateDate,
                    RoleId = item.RoleId
                });
            }
            _IStaffRolesRepository.AddRange(staffRolesList);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _mapper.Map<Staffs>(_IStaffsRepository.GetById(id));
            if (result != null)
            {
                result.Status = 3;
                _IStaffsRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<StaffDTO> GetAll(int languageId)
        {
            var result = _IStaffsRepository.GetAllStaff(languageId);
            var reuslts = _IStaffsRepository.GetStaffByRoles();
            List<StaffDTO> _staffList = new List<StaffDTO>();
            foreach (var item in result)
            {
                var staffMapper = _mapper.Map<StaffDTO>(item);
                staffMapper.StaffProcessPermisionsDTOs = _mapper.Map<List<StaffProcessPermisionsDTO>>(item.StaffProcessPermisions);
                staffMapper.StaffRolesDTO = _mapper.Map<List<StaffRolesDTO>>(item.StaffRoles);
                _staffList.Add(staffMapper);
            }
            foreach (var item in reuslts)
            {
                var staffMapper = _mapper.Map<StaffDTO>(item);
                staffMapper.StaffRolesDTO = _mapper.Map<List<StaffRolesDTO>>(item.StaffRoles);
                _staffList.Add(staffMapper);
            }
            return _staffList;
        }

        public List<StaffDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<StaffDTO>>(_IStaffsRepository.GetBy(x => x.Status == 1).ToList());
        }

        public StaffDTO GetBy(string email, string password)
        {
            var result = _IStaffsRepository.GetStaff(email, password);
            if (result != null)
            {
                var staffDto = _mapper.Map<StaffDTO>(result);
                staffDto.StaffProcessPermisionsDTOs = _mapper.Map<List<StaffProcessPermisionsDTO>>(result.StaffProcessPermisions);
                staffDto.StaffRolesDTO = _mapper.Map<List<StaffRolesDTO>>(result.StaffRoles);
                return staffDto;
            }
            return null;
        }

        public StaffDTO GetById(int id, int languageId)
        {
            var result = _IStaffsRepository.GetStaffById(id);
            if (result != null)
            {
                var staffDto = _mapper.Map<StaffDTO>(result);
                staffDto.StaffProcessPermisionsDTOs = _mapper.Map<List<StaffProcessPermisionsDTO>>(result.StaffProcessPermisions);
                staffDto.StaffRolesDTO = _mapper.Map<List<StaffRolesDTO>>(result.StaffRoles);
                return staffDto;
            }
            return null;
        }

        public bool StaffConfirm(StaffDTO entitiy)
        {
            var staffMapper = _mapper.Map<Staffs>(entitiy);
            var staff = _IStaffsRepository.Update(staffMapper);
            if (staff!=null)
            {
                _unitOfWork.SaveChanges();

                return true;
            }
            else
            {
                return true;
            }
        }

        public bool Update(StaffDTO entitiy)
        {
            var staffMapper = _mapper.Map<Staffs>(entitiy);
            var staffProcessPermisionsMapper = _mapper.Map<List<StaffProcessPermisions>>(entitiy.StaffProcessPermisionsDTOs);
            var staffRolesMapper = _mapper.Map<List<StaffRoles>>(entitiy.StaffRolesDTO);
            var staff = _IStaffsRepository.Update(staffMapper);
            if (staff != null)
            {
                _unitOfWork.SaveChanges();
                
                if (staffProcessPermisionsMapper != null)
                {
                    var staffProcessPermisions = _IStaffProcessPermisionsRepository.GetBy(x => x.StaffId == entitiy.Id).ToList();
                    _IStaffProcessPermisionsRepository.DeleteRange(staffProcessPermisions);
                    List<StaffProcessPermisions> staffProcessPermisionsList = new List<StaffProcessPermisions>();
                    foreach (var item in staffProcessPermisionsMapper)
                    {
                        staffProcessPermisionsList.Add(new StaffProcessPermisions()
                        {
                            StaffId = staff.Id,
                            ProcessId = item.ProcessId,
                            CreateDate = item.CreateDate,
                            UpdateDate = item.UpdateDate,
                            Status=1
                        });
                    }
                    _IStaffProcessPermisionsRepository.AddRange(staffProcessPermisionsList);
                    _unitOfWork.SaveChanges();

                    if (staffRolesMapper != null)
                    {
                        var staffRoles = _IStaffRolesRepository.GetBy(x => x.StaffId == entitiy.Id).ToList();
                        _IStaffRolesRepository.DeleteRange(staffRoles);
                        List<StaffRoles> staffRolesList = new List<StaffRoles>();
                        foreach (var item in staffRolesMapper)
                        {
                            staffRolesList.Add(new StaffRoles()
                            {
                                StaffId = staff.Id,
                                CreateDate = item.CreateDate,
                                UpdateDate = item.UpdateDate,
                                RoleId = item.RoleId
                            });
                        }
                        _IStaffRolesRepository.AddRange(staffRolesList);
                        _unitOfWork.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}