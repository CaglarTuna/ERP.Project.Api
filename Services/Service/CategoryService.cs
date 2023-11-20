using AutoMapper;
using Core;
using Core.IUnitOfWork;
using DTO;
using Entity;
using Services.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Services.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICategoriesRepository _ICategoriesRepository;  //Core Katmanı
        private readonly ICategoriesLanguageRepository _ICategoriesLanguageRepository;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper, ICategoriesRepository iCategoriesRepository, ICategoriesLanguageRepository ICategoriesLanguageRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _ICategoriesRepository = iCategoriesRepository;
            _ICategoriesLanguageRepository = ICategoriesLanguageRepository;
        }

        public void Add(CategoryDTO entitiy)
        {
            var categoriesMapper = _mapper.Map<Categories>(entitiy);
            var CategoryEntitiy = _ICategoriesRepository.Add(categoriesMapper);
            _unitOfWork.SaveChanges();

            var categoriesLanguageMapper = _mapper.Map<CategoriesLanguage>(entitiy.CategoryLanguageDTO);
            categoriesLanguageMapper.CategoriesId = CategoryEntitiy.Id;
            _ICategoriesLanguageRepository.Add(categoriesLanguageMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _ICategoriesRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _ICategoriesRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<CategoryDTO> GetAll(int languageId)
        {
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            var topcategory= _mapper.Map<List<CategoryDTO>>(_ICategoriesRepository.GetAllWithCategroyLanguage(languageId, 0).ToList());
            foreach (var item in topcategory)
            {
                var subCategory = _mapper.Map<List<CategoryDTO>>(_ICategoriesRepository.GetAllWithCategroyLanguage(languageId, item.Id).ToList());
                item.SubCategoryDto = subCategory;
                categoryDTOs.Add(item);
            }
            return categoryDTOs;
        }

        public List<CategoryDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<CategoryDTO>>(_ICategoriesRepository.GetBy(x => x.Status == 1).ToList());
        }

        public CategoryDTO GetById(int id, int languageId)
        {
            return _mapper.Map<CategoryDTO>(_ICategoriesRepository.GetWithByIdCategroyLanguage(languageId, id).FirstOrDefault());
        }

        public bool Update(CategoryDTO entitiy)
        {
            var data = _mapper.Map<Categories>(entitiy);
            var updatedvalue = _ICategoriesRepository.Update(data);
            if (updatedvalue != null)
            {
                _unitOfWork.SaveChanges();
                var categoriesLanguageMapper = _mapper.Map<CategoriesLanguage>(entitiy.CategoryLanguageDTO);
                var updatevalue = _ICategoriesLanguageRepository.Update(categoriesLanguageMapper);
                if (updatevalue != null)
                {
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
    }
}