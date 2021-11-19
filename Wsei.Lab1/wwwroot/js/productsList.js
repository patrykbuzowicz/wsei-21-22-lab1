(async () => {
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/signalr/updates")
        .build();

    await connection.start();

    connection.on("SendUpdate", (product) => {
        const alertBox = document.createElement("div");
        alertBox.className = "alert alert-primary";
        alertBox.innerText = "A new product called '" + product.name + "' was added, refresh the page!";

        document.getElementById("updates-container").appendChild(alertBox);
    });
})();