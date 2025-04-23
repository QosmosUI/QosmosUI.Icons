// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiMiraheze : ComponentBase
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
		builder.AddAttribute(15, "d", "m2.677 12.923 3.768.011 1.949 3.369-1.926 3.323H2.666L.727 16.292l1.95-3.369Zm-.004-8.6 3.761.011 1.944 3.367-1.922 3.326H2.662L.727 7.69l1.946-3.367Zm14.882 0 3.768.011 1.95 3.367-1.928 3.326h-3.801L15.606 7.69l1.949-3.367Zm0 8.6 3.768.011 1.95 3.369-1.928 3.323h-3.802l-1.937-3.334 1.949-3.369Zm-7.456 4.373 3.767.011 1.951 3.368L13.889 24h-3.801l-1.939-3.336 1.95-3.368Zm0-17.296 3.767.011 1.951 3.369-1.928 3.324h-3.801L8.149 3.368 10.099 0Zm0 8.628 3.767.011 1.951 3.368-1.928 3.325h-3.801l-1.939-3.336 1.95-3.368Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
