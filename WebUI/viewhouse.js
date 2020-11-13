function GetHouse()
{
    //console.log('https://localhost:44341/House/GetHouse?houseId='+location.search.substring(1));
    fetch('https://localhost:44341/House/GetHouse?houseId='+location.search.substring(1)) //fetch based on URL houseId
    .then(response => response.json())
    .then(result => {
        //console.log("Fetch successful!");
        document.querySelector('#houseid').innerHTML = result.houseId;
        document.querySelector('#bedrooms').innerHTML = result.bedrooms;
        document.querySelector('#bathrooms').innerHTML = result.bathrooms;
        document.querySelector('#floors').innerHTML = result.floors;
        document.querySelector('#location').innerHTML = result.location;
        document.querySelector('#ac').innerHTML = result.ac;
        document.querySelector('#heating').innerHTML = result.heating;
        document.querySelector('#price').innerHTML = result.price;

        document.querySelectorAll('#features li').forEach(element => element.remove()); //clear unordered list
        let listElement = document.querySelector('#features'); //gets unordered list
        let features = result.features;
        if (features!=null)
        {
            console.log("iterating through features with length="+features.length);
            for (let i=0; i<features.length; i++) 
            {
                let li = document.createElement('li');
                li.innerHTML = features[i].description;
                listElement.appendChild(li);
            }
        }
        else
        {

        }
    });
}