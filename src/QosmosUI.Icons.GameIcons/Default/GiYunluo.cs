// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiYunluo : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 25c-30.5 0-53.2 7.56-79.4 15.6-24.1 7.43-51.1 15.05-87.6 16.17V71h334V56.77c-36.5-1.12-63.5-8.74-87.6-16.17C309.2 32.56 286.5 25 256 25zM25 89v30h462V89H25zm32 48v350h30V137zm48 0v32.6c1.1 2.1 2.2 4.3 3.3 6.4 3.2-5.7 7.6-10.7 12.8-14.8-3.8-8.1-6.7-16.6-8.1-24.2zm84.1 0c-1.3 7.7-4.2 16.2-8 24.4 5.2 4.1 9.6 9.2 12.8 15 3.9-7.2 7.2-14.9 9.7-22.7 2.5 7.7 5.8 15.2 9.7 22.3 3.2-5.7 7.6-10.7 12.8-14.8-3.8-8.1-6.7-16.6-8.1-24.2zm105 0c-1.3 7.7-4.2 16.2-8 24.4 5.2 4.1 9.6 9.2 12.8 15 3.9-7.2 7.2-14.9 9.7-22.7 2.5 7.7 5.8 15.2 9.7 22.3 3.2-5.7 7.6-10.7 12.8-14.8-3.8-8.1-6.7-16.6-8.1-24.2zm105 0c-1.3 7.7-4.2 16.2-8 24.4 5.2 4.1 9.6 9.2 12.8 15 1.1-2 2.1-4 3.1-6.1V137zm25.9 0v350h30V137zm-274 32c-17.2 0-31 13.8-31 31s13.8 31 31 31 31-13.8 31-31-13.8-31-31-31zm105 0c-17.2 0-31 13.8-31 31s13.8 31 31 31 31-13.8 31-31-13.8-31-31-31zm105 0c-17.2 0-31 13.8-31 31s13.8 31 31 31 31-13.8 31-31-13.8-31-31-31zm-256 96v30h302v-30zm0 48v32.6c1.1 2.1 2.2 4.3 3.3 6.4 3.2-5.7 7.6-10.8 12.8-14.8-3.8-8.2-6.8-16.7-8.2-24.2zm84.1 0c-1.3 7.7-4.2 16.2-8 24.4 5.2 4.1 9.6 9.2 12.8 15 3.9-7.2 7.2-14.8 9.7-22.5 2.5 7.6 5.9 15 9.7 22.1 3.2-5.7 7.6-10.8 12.8-14.8-3.8-8.2-6.8-16.7-8.2-24.2zm105 0c-1.3 7.7-4.2 16.2-8 24.4 5.2 4.1 9.6 9.2 12.8 15 3.9-7.2 7.2-14.8 9.7-22.5 2.5 7.6 5.9 15 9.7 22.1 3.2-5.7 7.6-10.8 12.8-14.8-3.8-8.2-6.8-16.7-8.2-24.2zm105 0c-1.3 7.7-4.2 16.2-8 24.4 5.2 4.1 9.6 9.2 12.8 15 1.1-2 2.1-4 3.1-6.1V313zM151 345c-17.2 0-31 13.8-31 31s13.8 31 31 31 31-13.8 31-31-13.8-31-31-31zm105 0c-17.2 0-31 13.8-31 31s13.8 31 31 31 31-13.8 31-31-13.8-31-31-31zm105 0c-17.2 0-31 13.8-31 31s13.8 31 31 31 31-13.8 31-31-13.8-31-31-31z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
