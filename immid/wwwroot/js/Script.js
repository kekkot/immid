function openCity(evt, cityName) {
            var i, tabcontent, tablinks;
            tabcontent = document.getElementsByClassName("tabcontent");
            for (i = 0; i < tabcontent.length; i++) {
                tabcontent[i].style.display = "none";
            }
            tablinks = document.getElementsByClassName("tablinks");
            for (i = 0; i < tablinks.length; i++) {
                tablinks[i].className = tablinks[i].className.replace("_active", "");
            }
            document.getElementById(cityName).style.display = "block";
            evt.currentTarget.className += "_active";
        }
// Get the element with id="defaultOpen" and click on it
document.getElementById("defaultOpen").click();
document.getElementById("defaultOpen1").click();


function openCity1(evt, cityNames) {
             var i, tabcontents, tablinkss;
             tabcontents = document.getElementsByClassName("tabcontent-1");
             for (i = 0; i < tabcontents.length; i++) {
                 tabcontents[i].style.display = "none";
             }
             tablinkss = document.getElementsByClassName("tablinks-1");
             for (i = 0; i < tablinkss.length; i++) {
                 tablinkss[i].className = tablinkss[i].className.replace(" active", "");
             }
             document.getElementById(cityNames).style.display = "block";
             evt.currentTarget.className += " active";
         }

function openNav() {
    document.getElementById("mySidenav").style.width = "386px";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}


var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
    acc[i].addEventListener("click", function() {
        this.classList.toggle("active");
        var panel = this.nextElementSibling;
        if (panel.style.display === "block") {
            panel.style.display = "none";
        } else {
            panel.style.display = "block";
        }
    });
}

wow = new WOW({
    animateClass: 'animated',
    offset: 100,
    callback: function(box) {
        console.log("WOW: animating <" + box.tagName.toLowerCase() + ">")
    }
});
wow.init();
document.getElementById('moar').onclick = function() {
    var section = document.createElement('section');
    section.className = 'section--purple wow fadeInDown';
    this.parentNode.insertBefore(section, this);
};