// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPostOffice : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 28.28L41 227.9v27.5L256 55.72 471 255.4v-27.5L256 28.28zm0 52L128.1 199h255.8L256 80.28zM119 207.5l-78 72.4V487h103V368h82v119h245V279.9l-78-72.4V345H119V207.5zm34.7 9.5c1.3.9 2.6 1.9 4 2.9 11.4 8.2 25.3 17.6 39.2 26.5 13.8 8.9 27.7 17.4 38.9 23.4 5.6 3.1 10.5 5.5 14.3 7.1 2.8 1.2 5.2 1.8 5.9 2 .7-.2 3.1-.8 5.9-2 3.8-1.6 8.7-4 14.3-7.1 11.2-6 25.1-14.5 38.9-23.4 13.9-8.9 27.8-18.3 39.2-26.5 1.4-1 2.7-2 4-2.9H153.7zM256 278.9c-.2.1-.3.1 0 .1s.2 0 0-.1zm-119-51.8v92.1l68.8-45.9c-6.1-3.7-12.4-7.6-18.7-11.7-14.1-9.1-28.2-18.7-39.8-27-3.7-2.7-7.2-5.2-10.3-7.5zm238 0c-3.1 2.3-6.6 4.8-10.3 7.5-11.6 8.3-25.7 17.9-39.8 27-6.3 4.1-12.6 8-18.7 11.7l68.8 45.9v-92.1zm-151.9 56.3L157.8 327h196.4l-65.3-43.6c-1.4.8-2.8 1.6-4.1 2.3-5.9 3.2-11.2 5.8-15.8 7.8-4.7 2-8 3.5-13 3.5s-8.3-1.5-13-3.5c-4.6-2-9.9-4.6-15.8-7.8-1.3-.7-2.7-1.5-4.1-2.3zM288 368h96v64h-96v-64z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
