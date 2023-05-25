using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Infomation
    {
     

        public string titleChartEmployeeCreateMaxVi = "NHÂN VIÊN LẬP NHIỀU HÓA ĐƠN NHẤT";
        public string titleChartEmployeeCreateMinVi = "NHÂN VIÊN LẬP ÍT HÓA ĐƠN NHẤT";
        public string titleChartProductSoldMaxVi = "SẢN PHẨM BÁN CHẠY NHẤT";
        public string titleChartProductSoldMinVi = "SẢN PHẨM BÁN ĐƯỢC ÍT NHẤT";
        public string titleMessageVi = "Thông báo";
        public string titleMessageEn = "Notification";
        public string eventNullVi = "Vui lòng điền đầy đủ thông tin";
        public string eventNullEn = "Please input fully infomation";
        public int firstIndex = 0;
        public string checkDelVi = "Không thể xóa đối tượng này, bởi vì nó đang được sử dụng!";
        public string checkDelEn = "Can't delete this object , because it is being used!";
        public string checkCustomerPayVi = "Số tiền khách hàng trả không đủ!";
        public string checkCustomerPayEn = "The amount paid by customer isn't enough!";
        public string payVi = "Thanh toán thành công!";
        public string payEn = "Payment success";
        public string payFailedVi = "Thanh toán thất bại!";
        public string payFailedEn = "Payment failed";
        public string selectTableVi = "Vui lòng chọn bàn để lên món!";
        public string selectTableEn = "Please select table to add food!";
        public string selectTablePayVi = "Vui lòng chọn bàn để thanh toán!";
        public string selectTablePayEn = "Please select table to payment!";
        public string selectTableChangeVi = "Vui lòng chọn bàn muốn chuyển!";
        public string selectTableChangeEn = "Please select table to change!";
        public string checkCountVi = "Số lượng sản phẩm không đủ!";
        public string checkCountEn = "Product's quantity isn't enough!";
        public string checkDiscountVi = "Không đủ điều kiện để sử dụng giảm giá này!";
        public string checkDiscountEn = "Don't eligible condition to use this discount!";

        public string checkLoginVi = "Sai tên đăng nhập hoặc mật khẩu!";
        public string checkLoginEn = "Incorrect username or password!";

        public string checkPhoneSettingVi = "Số điện thoại không hợp lệ!";
        public string checkPhoneSettingEn = "Number phone is not valid!";
        public string checkLogOutVi = "Bạn muốn đăng xuất khỏi tài khoản này ? ";
        public string checkLogOutEn = "Would you like to log out this account? ";
        public string checkPasswordOldVi = "Mật khẩu cũ không đúng!";
        public string checkPasswordOldEn = "Old password incorrect!";
        public string checkPasswordNewVi = "Mật khẩu mới không trùng khớp!";
        public string checkPasswordNewEn = "New password doesn't match!";
        public string messageChangePasswordVi = "Đổi mật khẩu thành công!";
        public string messageChangePasswordEn = "Change password success!";
        public string messageChangePasswordfailedVi = "Đổi mật khẩu thất bại!";
        public string messageChangePasswordfailedEn = "Change password failed!";

        #region Message add,edit,delete,deleteAll,restore,restoreAll
        public string addVi = "Thêm mới thành công!";
        public string addEn = "Add new success!";
        public string addFailedVi = "Thêm mới thất bại!";
        public string addFailedEn = "Add new failed";
        public string editVi = "Sửa thành công!";
        public string editEn = "Edit success!";
        public string editFailedVi = "Sửa thất bại!";
        public string editFailedEn = "Edit failed!";
        public string deleteVi = "Xóa thành công!";
        public string deleteEn = "Delete success!";
        public string deleteFailedVi = "Xóa thất bại!";
        public string deleteFailedEn = "Delete failed!";
        public string deleteAllVi = "Xóa tất cả thành công!";
        public string deleteAllEn = "Delete all success!";
        public string deleteAllFailedVi = "Xóa tất cả thất bại!";
        public string deleteAllFailedEn = "Delete all failed!";
        public string restoreVi = "Khôi phục thành công!";
        public string restoreEn = "Restore success!";
        public string restoreFailedVi = "Khôi phục thất bại!";
        public string restoreFailedEn = "Restore failed!";
        public string restoreAllVi = "Khôi phục tất cả thành công!";
        public string restoreAllEn = "Restore all success!";
        public string restoreAllFailedVi = "Khôi phục tất cả thất bại!";
        public string restoreAllFailedEn = "Restore all failed!";
        public string messageEditVi = "Bạn muốn sửa thông tin này?";
        public string messageEditEn = "Would you like to edit this infomation?";
        public string messageDeleteVi = "Bạn muốn xóa đối tượng này?";
        public string messageDeleteEn = "Would you like delete this object?";
        public string messageDeleteAllVi = "Bạn muốn xóa tất cả các đối tượng này?";
        public string messageDeleteAllEn = "Would you like delete all this objects?";
        public string messageRestoreVi = "Bạn muốn khôi phục đối tượng này?";
        public string messageRestoreEn = "Would you like restore this object?";
        public string messageRestoreAllVi = "Bạn muốn khôi phục tất cả các đối tượng này?";
        public string messageRestoreAllEn = "Would you like restore all this objects?";

        public string checkAgeVi = "Tuổi phải lớn hơn hoặc bằng 18!";
        public string checkAgeEn = "Age must be greater than or equal to 18!";
        public string checkPhoneExistVi = "Số điện thoại đã tồn tại!";
        public string checkPhoneExistEn = "Number phone already exist!";


        #endregion

        public string MessageCheckExistVi(string name)
        {
            return string.Format("{0} đã tồn tại!", name);
        }

        public string MessageCheckExistEn(string name)
        {
            return string.Format("{0} already exist!", name);
        }
    }
}
