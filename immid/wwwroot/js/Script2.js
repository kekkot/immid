const accordion = document.getElementsByClassName('container');

for (i = 0; i < accordion.length; i++) {
    accordion[i].addEventListener('click', function () {
        this.classList.toggle('active')
    })
}


function openCity(evt, cityName) {
        var i, tabcontent, tablinks;
tabcontent = document.getElementsByClassName("tabcontent-project");
for (i = 0; i < tabcontent.length; i++) {
    tabcontent[i].style.display = "none";
        }
tablinks = document.getElementsByClassName("tablinks");
for (i = 0; i < tablinks.length; i++) {
    tablinks[i].className = tablinks[i].className.replace(" active", "");
        }
document.getElementById(cityName).style.display = "block";
evt.currentTarget.className += " active";
    }

// Get the element with id="defaultOpen" and click on it
document.getElementById("defaultOpen").click();


function openNav() {
    document.getElementById("mySidenav").style.width = "386px";
    }

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
    }


var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
    acc[i].addEventListener("click", function () {
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