const img = new Image();
img.src = "~/images/Jacksons mill map Image.png";

img.onload = function () {
    const canvas = document.getElementById("JacksonsMillMap");
    const ctx = canvas.getContext("2d");

    // Set the canvas size to match the image size
    canvas.width = img.width;
    canvas.height = img.height;

    // Draw the image on the canvas
    ctx.drawImage(img, 0, 0);

    // Plot a red point at coordinates (100, 100)
    ctx.fillStyle = "red";
    ctx.fillRect(100, 100, 3, 3);

    // Plot more points as needed
};

//functionality?
//CRUD (Create, Read, Update, Delete)
//add location
//edit/delete location
//display links to all locations
//search location? drop down list of all of the locations, selecting would route to description
