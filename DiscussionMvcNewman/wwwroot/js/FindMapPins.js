// Define an array of points and their corresponding details
var points = [
    { x: 10, y: 10, detail: "Point A" },
    { x: 300, y: 400, detail: "Point B" },
    { x: 500, y: 600, detail: "Point C" }
];

// Define a function to display the details of a clicked point
function showDetails(detail) {
    // Display the detail in a modal or tooltip
    // For example:
    alert(detail);
}

// Capture the click event on the image
var image = document.getElementById("image");
image.addEventListener("click", function (event) {
    // Calculate the coordinates of the click relative to the image
    var rect = image.getBoundingClientRect();
    var x = event.clientX - rect.left;
    var y = event.clientY - rect.top;

    // Check if the click is within the bounds of any point
    var point = points.find(function (point) {
        return x >= point.x - 5 && x <= point.x + 5 &&
            y >= point.y - 5 && y <= point.y + 5;
    });

    // If a point is found, display its details
    if (point) {
        showDetails(point.detail);
    }
});