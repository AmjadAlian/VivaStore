using AutoMapper;
using Landing.PL.Models.ViewModel;
using VivaStore.DAL.Models;
using VivaStore.PL.Areas.Dashboard.ViewModels;

namespace VivaStore.PL.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {
            //category control
            CreateMap<CategoryFormVM, Category>();
            CreateMap<Category,CategoryVM>();
            CreateMap<CategoryVM, Category>();
            CreateMap<Category, CategoryDetailsVM>().ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));
            //product control
            CreateMap<Product, ProductVM>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name)); 
            CreateMap<ProductFormVM, Product>()
          .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId));
            CreateMap<Product, ProductFormVM>()
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId));
            CreateMap<ProductDetailsVM, Product>().ReverseMap();


            //order control
            CreateMap<Order, OrderVM>()
           .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.UserName)) 
           .ReverseMap();

            CreateMap<OrderItem, OrderItemVM>().ForMember(dest => dest.ImgName, opt => opt.MapFrom(src => src.Product.ImgName))
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name)) 
                .ReverseMap();

			//slider 
			CreateMap<SliderHome, SliderHomeVM>().ReverseMap();

			//cart and cart items 
			CreateMap<Cart, CartViewModel>()
			.ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.CalculateTotal()));

			CreateMap<CartItem, CartItemVM>()
				.ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name))
				.ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Product.Price))
				.ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Product.Price * src.Quantity));

            //order
            CreateMap<OrderViewModel, Order>().ReverseMap();
        }
    }
}
