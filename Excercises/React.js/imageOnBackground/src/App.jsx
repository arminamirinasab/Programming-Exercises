import "bootstrap/dist/css/bootstrap.css";
import "./App.css";
import { useState } from "react";
import { Component } from "react";

/* Class Component 
class App extends Component {
  state = {
    image: "https://random-image-pepebigotes.vercel.app/api/random-image",
  };

  render() {
    return (
      <div className="App">
        <header className="App-header" style={{ backgroundImage: `url(${this.state.image})` }}>
          <div className="mb-3 w-50">
            <label htmlFor="url" className="form-label">
              Image URL
            </label>
            <input onChange={(event) => {this.setState({image: event.target.value})}} type="url" className="form-control"  value={this.state.image} id="url" />
          </div>
        </header>
      </div>
    );
  }
}
*/

// Functional Component
const App = () => {
  const [image, Image] = useState("https://random-image-pepebigotes.vercel.app/api/random-image");
  return (
    <div className="App">
      <header className="App-header" style={{ backgroundImage: `url(${image})` }}>
        <div className="mb-3 w-50">
          <label htmlFor="url" className="form-label">
            Image URL
          </label>
          <input onChange={(event) => {Image(event.target.value)}} type="url" className="form-control"  value={image} id="url" />
        </div>
      </header>
    </div>
  );
}

export default App;
