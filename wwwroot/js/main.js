

$(document).ready(function () {
   
  $("#dismiss, .overlay-sidebar").on("click", function () {
    // hide sidebar
    $("#sidebar").removeClass("active");
    // hide overlay
    $(".overlay-sidebar").removeClass("active");
  });

    $("#sidebarCollapse").on("click", function () {
        console.log("working");
    // open sidebar
    $("#sidebar").addClass("active");
    // fade in the overlay
    $(".overlay-sidebar").addClass("active");
    $(".collapse.in").toggleClass("in");
    $("a[aria-expanded=true]").attr("aria-expanded", "false");
  });
});
// scroll functions
// $(window).scroll(function(e) {
//      var
//     // add/remove class to navbar when scrolling to hide/show
//     var scroll = $(window).scrollTop();
//     if (scroll >= 150) {
//         $('.navbar').addClass("navbar-hide");
//     } else {
//         $('.navbar').removeClass("navbar-hide");
//     }

// });

$(window).scroll(function () {
  var scroll = $(window).scrollTop() + $(window).height();
  var height = $(document).height() - 100;
  console.log(scroll, height);
  if (scroll >= height) {
    $(".back-to-top").addClass("d-md-block");
  } else {
    $(".back-to-top").removeClass("d-md-block");
  }
  //   if ($(window).scrollTop() + $(window).height() > $(document).height() - 100) {
  //     $(".back-to-top").addClass("display");
  //   } else {
  //     $(".back-to-top").removeClass("none");
  //   }
});
