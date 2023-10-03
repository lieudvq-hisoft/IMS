using AutoMapper;
using Data.Entities;
using Data.Models;

namespace Services.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Customer, CustomerModel>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.User.Address))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.User.PhoneNumber));
            //CreateMap<UserCreateModel, User>();
            //CreateMap<User, UserPostModel>();
            //CreateMap<User, UserModel>();
            //CreateMap<User, UserViewModel>();
            //CreateMap<UserRole, UserRoleModel>();

            //CreateMap<Role,RoleModel>();
            //CreateMap<UpdateRoleModel, Role>();
            //CreateMap<CreateRoleModel, Role>();

            //CreateMap<Post, PostModel>();
            //CreateMap<Post, PostViewModel>();
            //CreateMap<PostCreateModel, Post>();

            //CreateMap<Category, CategoryModel>();
            //CreateMap<CategoryUpdateModel, Category>();
            //CreateMap<CategoryCreateModel, Category>();

            //CreateMap<Report, ReportModel>();
            //CreateMap<CreateReportModel, Report>();

            //CreateMap<Request, RequestModel>();
            //CreateMap<UpdateRequestModel, Request>();
            //CreateMap<CreateRequestModel, Request>();
            //CreateMap<SendRequestModel, Request>();

            //CreateMap<NotificationAddModel, Notification>();
            //CreateMap<Notification, NotificationModel>().ReverseMap();

            //CreateMap<ResourceCreateModel, Resource>();
            //CreateMap<Resource, ResourceModel>().ReverseMap();

            //CreateMap<PostCategoryCreateModel, PostCategory>();
            //CreateMap<PostCategory, PostCategoryViewModel>();
            //CreateMap<PostCategory, PostCategoryModel>().ReverseMap();

            //CreateMap<TradingCreateModel, Trading>();
            //CreateMap<Trading, TradingModel>();
            //CreateMap<Trading, TradingViewModel>();
            //CreateMap<SendTradingModel, Trading>();

            //CreateMap<TradingUserChatCreateModel, TradingUserChat>();
            //CreateMap<TradingUserChat, TradingUserChatModel>();
            //CreateMap<TradingUserChat, TradingUserChatViewModel>();

            //CreateMap<MessageCreateModel, Message>();
            //CreateMap<Message, MessageModel>();
            //CreateMap<Message, MessageViewModel>();
        }
    }
}
