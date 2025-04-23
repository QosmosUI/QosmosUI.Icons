// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiFirewalla : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.156 0c-3.602 4.89.391 7.768 2.61 11.893-.751 1.527-1.745 3.08-2.733 4.836l-.072.025c-.849-.983-1.99-1.85-3.033-2.967 2.606-5.783-.809-9.812-.809-9.812a12.555 12.555 0 0 0-1.916 2.021c-2.296 3.06-2.027 5.897-2.027 5.897C4.176 19.07 12.125 24 12.125 24a21.738 21.738 0 0 0 2.139-1.594c5.864-4.974 5.564-10.513 5.564-10.513.122-4.308-1.622-5.905-4.82-9.014A83.864 83.864 0 0 1 12.156 0zm.281 17.37zm.397.687a4.298 4.298 0 0 1 .14.328 4.463 4.463 0 0 0-.14-.328zm.266.718a4.289 4.289 0 0 1 .14.791c.024.286.023.588-.006.91a5.23 5.23 0 0 0 .006-.91 4.513 4.513 0 0 0-.14-.79z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
