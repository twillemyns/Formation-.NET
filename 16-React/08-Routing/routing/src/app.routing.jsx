import { createBrowserRouter } from "react-router-dom";
import HomePage from "./pages/HomePage";
import FormPage from "./pages/FormPage";

const router = createBrowserRouter([
    {
        path: "/",
        children: [
            { path: "/", element: <HomePage/> },
            { path: "/create", element: <FormPage/> },
            { path: "/edit/:id", element: <FormPage/> }
        ]
    }
]);

export default router;