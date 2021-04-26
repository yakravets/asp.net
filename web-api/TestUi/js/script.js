var url = "https://localhost:44342/films";

onload = async () => {
    var responce = await fetch(url);
    var data = await responce.json();

    let main = document.querySelector("#main");
    main.innerHTML = "";

    data.forEach(el => {
        main.innerHTML  += `
            <div class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">${el.name}</h5>
                    <p class="card-text">Rating: <span class="badge bg-secondary">${el.rating}</span></p>
                    <a href="#" class="btn btn-primary">Go somewhere</a>
                </div>
            </div>
        `
    });
}