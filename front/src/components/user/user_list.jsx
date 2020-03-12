import React from "react";

const UserList = React.memo(({ users }) => {
  return (
    <div className="user-list">
      <ul>
        {users &&
          users.map(user => (
            <li>
              {user.name} / {user.email}
            </li>
          ))}
      </ul>
    </div>
  );
});

export default UserList;
