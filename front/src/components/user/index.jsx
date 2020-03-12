import React from "react";
import { useQuery } from "@apollo/react-hooks";
import { gql } from "apollo-boost";

import UserList from "./user_list";

const GET_USERS_QUERY = gql`
  {
    users {
      id
      email
      name
      loginName
    }
  }
`;

const User = React.memo(() => {
  const { loading, error, data } = useQuery(GET_USERS_QUERY);

  if (loading) return <p>Loading...</p>;
  if (error) return <p>Error: (error)</p>;

  return <UserList users={data.users} />;
});

export default User;
