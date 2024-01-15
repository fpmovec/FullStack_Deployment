import GetDockerTest from "./Requests";
import "./App.css";
import { useState } from "react";

function App() {
  const [str, setStr] = useState<string[]>([]);

  const handleClick = async () => {
    const str1 = await GetDockerTest(1);
    const str2 = await GetDockerTest(2);

    setStr([str1, str2]);
  };

  return (
    <>
      <button onClick={() => handleClick()}>Get Data</button>
      <div>
        {str.length > 0 ? (
          <div>
            <div>{str[0]}</div>
            <div>{str[1]}</div>
          </div>
        ) : (
          <>Nothing</>
        )}
      </div>
    </>
  );
}

export default App;
