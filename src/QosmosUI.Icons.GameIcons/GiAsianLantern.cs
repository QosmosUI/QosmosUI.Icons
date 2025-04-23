// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiAsianLantern : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M247 20v67h18V20h-18zm174.637 63.637l-44 44 12.726 12.726 44-44-12.726-12.726zm-331.274 2L77.637 98.363l44 44 12.726-12.726-44-44zM201 105v30h110v-30H201zm-9 48c-13 0-27.447 6.922-38.238 15.914a76.393 76.393 0 0 0-6.487 6.086H288v18H137v46h151v18H137v46h151v18H137v46h151v18H147.275a76.393 76.393 0 0 0 6.487 6.086C164.552 400.078 179 407 192 407h128c13 0 27.447-6.922 38.238-15.914 5.396-4.496 9.859-9.456 12.774-13.828C373.927 372.886 375 369 375 368V192c0-1-1.073-4.886-3.988-9.258-2.915-4.372-7.378-9.332-12.774-13.828C347.448 159.922 333 153 320 153H192zM44.557 179.371l-5.114 17.258 54 16 5.114-17.258-54-16zm420.797.027l-52 16 5.292 17.204 52-16-5.292-17.204zM32 279v18h64v-18H32zm384 0v18h64v-18h-64zm2.557 84.371l-5.114 17.258 54 16 5.114-17.258-54-16zm-325.203.027l-52 16 5.292 17.204 52-16-5.292-17.204zM201 425v18h110v-18H201zm189.363 8.637l-12.726 12.726 44 44 12.726-12.726-44-44zm-268.726 2l-44 44 12.726 12.726 44-44-12.726-12.726zM241.96 456l-2.576 4.613c-6.843 12.263-8.313 24.248-8.313 24.248L229.777 495h52.446l-1.295-10.139s-1.47-11.985-8.313-24.248L270.04 456h-28.078z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
