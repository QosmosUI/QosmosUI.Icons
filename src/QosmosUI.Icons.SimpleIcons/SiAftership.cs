// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAftership : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M22.549 9.604a10.462 10.462 0 0 0-3.388-6.838A10.632 10.632 0 0 0 12 0a10.64 10.64 0 0 0-7.16 2.764 10.465 10.465 0 0 0-3.428 7.74c0 2.371.81 4.672 2.298 6.529a10.617 10.617 0 0 0 5.895 3.698L12 24l2.395-3.27a10.593 10.593 0 0 0 5.895-3.697 10.442 10.442 0 0 0 2.26-7.43zm-11.306 6.28a.26.26 0 0 1-.034.125.254.254 0 0 1-.347.092l-3.906-2.237a1.005 1.005 0 0 1-.505-.865V8.624a.26.26 0 0 1 .033-.126.254.254 0 0 1 .347-.092l3.907 2.237c.152.089.281.214.368.366.09.151.135.324.135.5v4.372zM12 9.48c-.176 0-.35-.047-.503-.133L7.5 7.057a.241.241 0 0 1-.09-.092.249.249 0 0 1 .09-.342l3.997-2.289a1.025 1.025 0 0 1 1.007 0l3.996 2.29a.24.24 0 0 1 .09.092.247.247 0 0 1 0 .25.271.271 0 0 1-.09.092l-3.997 2.289A1.005 1.005 0 0 1 12 9.48ZM17.546 13a.996.996 0 0 1-.503.866l-3.908 2.237a.254.254 0 0 1-.38-.218V11.51c0-.175.047-.348.135-.501.089-.152.216-.28.368-.366l3.907-2.238a.254.254 0 0 1 .38.219z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
