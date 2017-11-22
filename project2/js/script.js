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









window.onscroll = function() {scrollFunction()};

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById("myBtn").style.display = "block";
    } else {
        document.getElementById("myBtn").style.display = "none";
    }
}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}




        var map = new google.maps.Map(document.getElementById('map-canvas'),{
            center:{
            lat: 12.9715987,
            lng: 77.59456269999998
            },
            zoom: 12
        });

        var marker = new google.maps.Marker({
            position:{
            lat: 12.9715987,
            lng: 77.59456269999998
            },
            map: map,
            draggable:true
        });

        var searchBox = new google.maps.places.SearchBox(document.getElementById('pac-input'));

        google.maps.event.addListener(searchBox , 'place_changed' , function(){
            var places = searchBox.getPlaces();
            var bounds =  new google.maps.LatLngBounds();
            var i,place;
            for( i = 0; palce = places[i]; i++)
            {
            bounds.extend(place.geometry.location);
            marker.setPosition(place.geometry.location);
            }
            map.fitBounds(bounds);
            map.setZoom(12);
        });



        


