﻿namespace SimpleEcommerceV2.Shared.InOut.Requests;

public record AuthRequest(string Email, string Password, bool OnlyTokenBody=false) { }

