$(function() {
   //Define functionality
   $('#birthday').datepicker({dateFormat: "mm-dd"});
   $('.ball').draggable();

   //Choose a random easing
   var easings = ['shake', 'zoomInDown', 'jackInTheBox'];
   $('#birthdayTitle').addClass('animated').addClass(easings[Math.floor(Math.random() * easings.length)]);

   //When a checkbox is changed, update the corresponding DOM element
   $('.balloonCheck').on('change', function(){
      $('#' + $(this).attr('control')).toggle();
   });
});