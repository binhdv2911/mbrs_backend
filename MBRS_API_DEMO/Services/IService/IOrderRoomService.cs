﻿using MBRS_API.Models;
using MBRS_API.Models.ViewModels;

namespace MBRS_API.Services.IService
{
    public interface IOrderRoomService
    {
        public List<RatingPercentViewModel> getRatingPercent(int typeRoomID);
        public List<RatingViewModel> getAllListRating(int typeRoomID);
        public List<TypeRoom> getTypeRoomInformation(int typeRoomID);
        public List<TypeRoomViewModel> getAllTypeRoom(DateTime checkInt, DateTime checkOut, int numberOfRoom, int numberOfChild, int numberOfAdult);
        public int createOrderRoomUnpaymentForCustomer(OrderRoomUnpayment orderRoomUnpayment);
        public int createOrderRoom(OrderRoomInformationViewModel orderInformationViewModel);
        public List<CustomerViewModel> getCustomerInformationByID(int accountID);
        public int createOrderRoomForCustomer(OrderRoomInformationViewModel orderInformationViewModel);
        public int createOrderRoomUnpayment(OrderRoomUnpayment orderRoomUnpayment);

        public List<CustomerViewModel> getCustomerInformationByIdentityNumber(string identityNumber);
        public int createOrderRoomReceptionist(OrderRoomInformationViewModel orderInformationViewModel);
        public int createOrderRoomCash(OrderRoomUnpayment orderRoomUnpayment);
    }
}
