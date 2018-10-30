﻿// Write your JavaScript code.
$(document).ready(function(){

    //Lock custom navbar when scrolled.
    $(window).scroll(function() {
        var distanceFromTop = $(document).scrollTop();
        if (distanceFromTop >= $('#Navbar').height())
        {
            $('#Navbar').addClass('custom_navbar');
        }
        else
        {
            $('#Navbar').removeClass('custom_navbar');
        }
    });

    //Show Hidden Gallery Full Size Display on Img click.
    $('img.img_moon_phase_thumbnail').on( "click", function() {
        $('#fullscalegalleryimg').show();
        var srcImg = $(this).attr("src");
        var imgName = $(this).attr("alt");
        $('#fullscalegalleryimg img').attr("src", srcImg);
        $('#fullscalegalleryimg h1').html(imgName);
        console.log(srcImg);
      });
    //Hidden Gallery Full Size Display on click.
      $("#fullscalegalleryimg").click(function(){
		$(this).hide();
	});
});