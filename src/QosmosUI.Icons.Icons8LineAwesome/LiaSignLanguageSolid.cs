// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaSignLanguageSolid : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 32 32";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M 20.224609 1.3671875 L 18.607422 2.5429688 L 26.982422 14.070312 C 26.937896 14.666625 26.639523 15.219067 26.144531 15.564453 L 23.339844 17.523438 C 22.452844 18.143438 21.248656 17.951891 20.597656 17.087891 L 14.798828 9.3984375 L 13.201172 10.601562 L 19 18.292969 C 19.788 19.336969 20.980406 19.888672 22.191406 19.888672 C 22.983406 19.888672 23.784375 19.652109 24.484375 19.162109 L 27.289062 17.203125 C 28.360062 16.456125 29 15.229828 29 13.923828 L 29 7 L 27 7 L 27 10.689453 L 20.224609 1.3671875 z M 17.210938 2.3222656 L 15.59375 3.4980469 L 20.839844 10.71875 L 22.457031 9.5429688 L 17.210938 2.3222656 z M 15.371094 4.8945312 L 13.751953 6.0703125 L 18.378906 12.4375 L 19.996094 11.261719 L 15.371094 4.8945312 z M 12.580078 15.185547 L 11.419922 16.8125 L 14.480469 19 L 3 19 L 3 21 L 17.251953 21 C 17.716967 21.377341 18 21.941045 18 22.544922 L 18 26 C 18 27.103 17.103 28 16 28 L 6 28 L 6 30 L 16 30 C 18.206 30 20 28.206 20 26 L 20 22.544922 C 20 21.255922 19.373219 20.038062 18.324219 19.289062 L 12.580078 15.185547 z M 2 22 L 2 24 L 11 24 L 11 22 L 2 22 z M 3 25 L 3 27 L 11 27 L 11 25 L 3 25 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
