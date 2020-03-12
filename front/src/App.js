import React from "react";
import { ApolloProvider } from "@apollo/react-hooks";
import client from "./apollo";
import "./App.css";

import UserContainer from "./components/user";

function App() {
  return (
    <ApolloProvider client={client}>
      <div className="App">
        <UserContainer />
      </div>
    </ApolloProvider>
  );
}

export default App;
