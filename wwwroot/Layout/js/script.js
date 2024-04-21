document.addEventListener("DOMContentLoaded", function() {
    var maxItems =50 ; // Số lượng tối đa của các khung
    var khungContainer = document.querySelector('.khung');
    var khungs = khungContainer.querySelectorAll('.theobs');

    // Kiểm tra nếu số lượng khung vượt quá số lượng tối đa
    if (khungs.length > maxItems) {
        // Ẩn các khung thừa
        for (var i = maxItems; i < khungs.length; i++) {
            khungs[i].style.display = 'none';
        }
        
        // Tạo thanh cuộn
        khungContainer.style.overflowY = 'auto';
        khungContainer.style.maxHeight = 'calc(100% - 20px)'; // Đảm bảo thanh cuộn không vượt quá chiều cao của container
    }
});

