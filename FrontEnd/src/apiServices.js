
 
export async function fetchData(url, query_param = null) {
    
    if (query_param !== null) {
        url = `${url}?${new URLSearchParams(query_param).toString()}`;
    }

    const response = await fetch(
        url, 
        {
            method: 'GET'
        }
    );

    return await response.json();
}


async function SendData(u, data) {

    var url = `${u}?${new URLSearchParams(data).toString()}`;

    await fetch(url, {
        method: "Post"
    });
    
}

async function GetData(u, data) {

    var url = `${u}?${new URLSearchParams(data).toString()}`;

    return await fetch(url, {
        method: "GET"
    }).then((res) => {
        return res.json();
    }).then((data) => {
        return data;
    });

}