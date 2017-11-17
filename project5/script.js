$('#hien-mk').on('click',function () {
var passInput=$('#password-signup').attr('type');			
	if (passInput == 'password') {
		$('#password-signup').attr('type', 'text');
	}
	if (passInput == 'text') {
		$('#password-signup').attr('type', 'password');
	}
});

$('.taotaikhoan').on('click', function(){
	$('#sign-in').modal('hide');
	setTimeout(function(){
		$('#sign-up').modal('show');}, 500);	
});



$('.count').each(function () {
    $(this).prop('Counter',0).animate({
        Counter: $(this).text()
    }, {
        duration: 4000,
        easing: 'swing',
        step: function (now) {
            $(this).text(Math.ceil(now));
        }
    });
});

$(function () {
  $('[data-toggle="popover"]').popover()
})