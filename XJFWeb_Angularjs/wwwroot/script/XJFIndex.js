jQuery.support.cors = true;
$.ajax({
    type: "Post",
    data: {},
    dataType: "JSON",
    async: false,
    url: "http://192.168.204.1/api/test/get",
    success: function (data) {
        var result = data;
        alert(123);
    },
    error: function (data) {
        alert(321);
    }
});