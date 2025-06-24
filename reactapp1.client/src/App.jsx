import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [parks, setParks] = useState();

    useEffect(() => {
        populateParkData();
    }, []);

    const contents = parks === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tableLabel">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Otopark</th>
                </tr>
            </thead>
            <tbody>
                {parks.map(parks =>
                    <tr key={parks.parkID}>
                        <td>{parks.parkID}</td>
                        <td>{parks.parkName}</td>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <div>
            <h1 id="tableLabel">Weather forecast</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {contents}
        </div>
    );
    
    async function populateParkData() {
        const response = await fetch('park');
        if (response.ok) {
            const data = await response.json();
            setParks(data);
        }
    }
}

export default App;