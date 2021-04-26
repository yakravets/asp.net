var url = "https://localhost:44342/films";

onload = mainLoad;

async function mainLoad() {
    var response = await fetch(url);
    var data = await response.json();

    let main = rootElement();
    main.innerHTML = '';

    if (data.length == 0) {
        main.innerHTML = '<h1><i class="bi bi-search"></i> Film collection is empty!</h1>';
    }
    else {
        data.forEach(el => {
            main.innerHTML += `
                <div class="card" style="width: 18rem;">
                    <div class="card-body">
                        <h5 class="card-title">${el.name}</h5>
                        <p class="card-text">Rating: <span class="badge bg-secondary">${el.rating}</span></p>
                        <a href="#" class="btn btn-warning" data-id=${el.id} onclick=renderEditFilm(${el.id})><i class="bi bi-pencil"></i> Edit</a>
                        <a href="#" class="btn btn-danger" data-id=${el.id} onclick="deleteFilm(${el.id})"><i class="bi bi-x-circle"></i> Delete</a>
                    </div>
                </div>`;
        });
    }
}

function rootElement() {
    return document.querySelector("#main");
}

async function renderAddFields() {

    let data = await getGenres();
    let optionsList = await getGenresOptionsList(data);

    let root = rootElement();
    root.innerHTML = `
    <div class="col-2 item">
        <div class="input-group flex-nowrap">
            <span class="input-group-text" id="addon-wrapping">Name</span>
            <input type="text" id="name" class="form-control" placeholder="Name" aria-label="Name" aria-describedby="addon-wrapping" required>
        </div>
    </div>
    <div class="col-2 item">
        <div class="input-group flex-nowrap">
            <span class="input-group-text" id="addon-wrapping">Rating</span>
            <input type="text" id="rating" class="form-control" placeholder="Rating" aria-label="Rating" aria-describedby="addon-wrapping" required>
        </div>
    </div>
    <div class="input-group mb-2 item">
        <label class="input-group-text" for="genrelist">Genre</label>
        <select class="form-select" id="genrelist" required>
            ${optionsList}
        </select>
    </div>
    <div class="col-2 item">
        <button type="button" class="btn btn-success" onclick="saveNewFilm()"><i class="bi bi-check-circle-fill"></i> Save</button>
    </div>
    `;
}

async function getGenres() {
    const genreurl = 'https://localhost:44342/genres';
    let resp = await fetch(genreurl);
    let json = await resp.json();
    return json;
}

async function getGenresOptionsList(data, activeid = 0) {

    let optionsList = '';
    data.forEach(el => {
        optionsList += `<option value="${el.id}" ${(activeid == el.id ? "selected" : "")}>${el.name}</option>`;
    });

    return optionsList;
}

async function saveNewFilm() {

    let name = document.querySelector("input#name").value;
    let rating = document.querySelector("input#rating").value;
    let genre = document.querySelector("select#genrelist").value;

    let result = await fetch(url, {
        method: 'POST',
        body: JSON.stringify({ Name: name, Rating: parseFloat(rating), GenreId: parseInt(genre) }),
        headers: {
            'Content-Type': 'application/json'
        }
    });

    if (result.status == 200) {
        mainLoad();
    };
}

async function deleteFilm(id) {
    let deleteUrl = url + '?id=' + id;

    let result = await fetch(deleteUrl,
        {
            method: 'DELETE'
        });

    if (result.status == 200) {
        mainLoad();
    }
}

async function renderEditFilm(id) {

    const filmParams = url + '?id=' + id;
    let result = await fetch(filmParams);
    let dataArray = await result.json();
    item = dataArray[0];

    let data = await getGenres();
    let optionsList = await getGenresOptionsList(data, item.rating);

    let root = rootElement();
    root.innerHTML = `
    <div class="col-2 item">
        <div class="input-group flex-nowrap">
            <span class="input-group-text" id="addon-wrapping">Name</span>
            <input type="text" id="name" class="form-control" placeholder="Name" aria-label="Name" aria-describedby="addon-wrapping" value="${item.name}">
        </div>
    </div>
    <div class="col-2 item">
        <div class="input-group flex-nowrap">
            <span class="input-group-text" id="addon-wrapping">Rating</span>
            <input type="text" id="rating" class="form-control" placeholder="Rating" aria-label="Rating" aria-describedby="addon-wrapping" value="${item.rating}">
        </div>
    </div>
    <div class="input-group mb-2 item">
        <label class="input-group-text" for="genrelist">Genre</label>
        <select class="form-select" id="genrelist" required>
            ${optionsList}
        </select>
    </div>
    <div class="col-2 item">
        <button type="button" class="btn btn-danger" onclick="editFilm(${item.id})"><i class="bi bi-check-circle-fill"></i> Save</button>
    </div>
    `;
}

async function editFilm(id) {
    let name = document.querySelector("input#name").value;
    let rating = document.querySelector("input#rating").value;
    let genre = document.querySelector("select#genrelist").value;

    let result = await fetch(url, {
        method: 'PUT',
        body: JSON.stringify({
            Name: name,
            Rating: parseFloat(rating),
            GenreId: parseInt(genre),
            Id: parseInt(id)
        }),
        headers: {
            'Content-Type': 'application/json'
        }
    });

    if (result.status == 200) {
        mainLoad();
    };
}