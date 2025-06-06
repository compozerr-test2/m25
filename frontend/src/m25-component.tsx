import React from "react";

interface Props {
   name: string;
}

const M25Component = (props: Props) => {
   return (
      <div>
         Hello {props.name}
      </div>
   );
}

export default M25Component;