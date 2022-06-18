
export function startCarousel(carouselId) {
    var myCarousel = document.getElementById(carouselId);
    var carousel = new bootstrap.Carousel(myCarousel);
    carousel.cycle(); // la chiamata a cycle fa partire subito il carousel
}
