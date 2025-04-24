// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiGitCompare : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
		builder.AddAttribute(14, "d", "M25.453 21.285v-9.89c0-4.739-4.726-4.726-4.726-4.726h-1.575v-3.151l-4.726 4.727 4.726 4.726v-3.151c0 0 0.657 0 1.575 0 1.389 0 1.575 1.575 1.575 1.575v9.89c-0.939 0.546-1.575 1.548-1.575 2.714 0 1.739 1.412 3.151 3.151 3.151s3.151-1.413 3.151-3.151c0-1.163-0.637-2.168-1.575-2.714zM23.878 25.575c-0.869 0-1.576-0.705-1.576-1.575 0-0.869 0.706-1.575 1.576-1.575 0.871 0 1.575 0.706 1.575 1.575 0 0.871-0.705 1.575-1.575 1.575zM6.547 11.287v9.889c0 4.739 4.727 4.727 4.727 4.727h1.575v3.151l4.726-4.726-4.726-4.727v3.151c0 0-0.657 0-1.575 0-1.389 0-1.575-1.575-1.575-1.575v-9.889c0.939-0.547 1.575-1.549 1.575-2.715 0-1.739-1.412-3.151-3.151-3.151s-3.151 1.412-3.151 3.151c0 1.164 0.636 2.168 1.575 2.715zM8.123 10.214c-0.869 0-1.575-0.704-1.575-1.575 0-0.869 0.706-1.575 1.575-1.575 0.872 0 1.575 0.706 1.575 1.575 0 0.872-0.704 1.575-1.575 1.575z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
