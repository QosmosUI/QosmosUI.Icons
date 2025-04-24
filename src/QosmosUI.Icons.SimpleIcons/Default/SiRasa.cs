// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiRasa : ComponentBase
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
		builder.AddAttribute(15, "d", "m20.848 15.852-3.882-2.034H.97V7.515h22.06v6.303h-2.182v2.034ZM0 6.545v8.243h16.727l5.091 2.667v-2.667H24V6.545H0Zm1.94 1.94h4.12v2.18l-1.33.517 1.362 1.666H4.84l-1.06-1.296-.87.339v.957h-.97V8.485ZM8 12.848h-.97V8.485h4.364v4.363h-.97v-1.454H8v1.454Zm4.364-1.696V8.485h4.363v.97h-3.394v.727h3.394v2.666h-4.363v-.97h3.394v-.726h-3.394Zm5.333-.243V8.485h4.364v4.363h-.97v-1.454h-2.424v1.454h-.97V10.91Zm-14.788-.06 2.182-.848v-.546H2.909v1.395ZM8 9.456v.97h2.424v-.97H8Zm13.09.97v-.97h-2.423v.97h2.424Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
