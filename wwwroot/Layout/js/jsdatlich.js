// Đảm bảo rằng DOM đã được tải xong trước khi thực thi mã JavaScript
document.addEventListener("DOMContentLoaded", function() {
    // Gọi hàm toggleInfo() ngay khi trang được tải để hiển thị nội dung
    toggleInfo();
});

function toggleInfo() {
    var infoSection = document.getElementById('infoSection');
    var toggleBtn = document.getElementById('toggleBtn');

    if (infoSection.style.display === 'none') {
        infoSection.style.display = 'block';
        toggleBtn.textContent = '...Thu gọn'; // Thay đổi nội dung của button khi hiển thị thông tin
    } else {
        infoSection.style.display = 'none';
        toggleBtn.textContent = '...Xem thêm'; // Thay đổi nội dung của button khi ẩn thông tin
    }
}
