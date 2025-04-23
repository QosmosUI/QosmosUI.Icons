// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiAndroid : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M3.809 5.696h9.383v6.807c0 0.623-0.502 1.125-1.113 1.125h-0.769v2.32c0 0.583-0.469 1.052-1.051 1.052-0.583 0-1.055-0.47-1.055-1.052v-2.32h-1.408v2.32c0 0.582-0.472 1.052-1.055 1.052-0.571 0-1.042-0.47-1.042-1.052l-0.009-2.32h-0.757c-0.622 0-1.124-0.501-1.124-1.125v-6.807zM2.357 5.502c-0.582 0-1.053 0.471-1.053 1.042v4.396c0 0.583 0.471 1.052 1.053 1.052s1.042-0.47 1.042-1.052v-4.396c0-0.571-0.468-1.042-1.042-1.042zM13.222 5.328h-9.454c0-1.625 0.972-3.036 2.413-3.771l-0.727-1.338c-0.041-0.072-0.021-0.164 0.051-0.205 0.071-0.031 0.164-0.011 0.205 0.062l0.735 1.349c0.625-0.277 1.32-0.43 2.055-0.43s1.43 0.153 2.055 0.429l0.735-1.349c0.041-0.072 0.134-0.092 0.205-0.062 0.072 0.041 0.092 0.133 0.051 0.205l-0.727 1.338c1.432 0.736 2.403 2.147 2.403 3.772zM6.741 3.223c0-0.215-0.173-0.399-0.397-0.399-0.216 0-0.389 0.184-0.389 0.399 0 0.214 0.173 0.398 0.389 0.398 0.224 0.001 0.397-0.183 0.397-0.398zM11.045 3.223c0-0.215-0.173-0.399-0.389-0.399-0.225 0-0.397 0.184-0.397 0.399 0 0.214 0.173 0.398 0.397 0.398 0.216 0.001 0.389-0.183 0.389-0.398zM14.643 5.502c-0.573 0-1.042 0.46-1.042 1.042v4.396c0 0.583 0.469 1.052 1.042 1.052 0.582 0 1.053-0.47 1.053-1.052v-4.396c-0.001-0.582-0.471-1.042-1.053-1.042z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
