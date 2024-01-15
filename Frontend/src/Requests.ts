const GetDockerTest = async (id: number) => {
  let result: string = " ";

  const response = await fetch(`/api/docker_test_${id}`, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
    },
  });

  result = (await response.json()) as string;

  return result;
};

export default GetDockerTest;
