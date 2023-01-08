import BaseRequest from "@/requests/base-request.model";

export default class LoginRequest extends BaseRequest {
    public email?: String;

    public password?: String;

    public rememberMe: Boolean = false;
}