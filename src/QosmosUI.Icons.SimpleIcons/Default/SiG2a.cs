// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiG2a : ComponentBase
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
		builder.AddAttribute(15, "d", "M24 15.419s-1.8844-3.5895-3.1571-6.0153a1.6802 1.6802 0 0 0-.4674-.5659 1.3021 1.3021 0 0 0-.7927-.2572 1.239 1.239 0 0 0-.7715.2572 1.6802 1.6802 0 0 0-.4674.5659c-1.2726 2.4258-3.1783 6.0153-3.1783 6.0153l1.7391.0004 2.6781-5.1339 1.2586 2.4128h-1.9378l.6832 1.3053h1.9356l.7386 1.4154H24zM3.4872 13.9588c-1.071 0-1.9392-.8682-1.9392-1.9392s.8682-1.9392 1.9392-1.9392l3.9342-.0031V8.6212H3.3946C1.5174 8.6236-.0024 10.1473 0 12.0244c.0024 1.8738 1.5208 3.3922 3.3946 3.3946h4.0268v-4.1277H3.053v1.4571l2.8447-.0001v1.2141l-2.4105-.0036zm7.2305-1.2109 3.0641-.0002c1.1395 0 2.0633-.9238 2.0633-2.0633s-.9238-2.0633-2.0633-2.0633h-3.6463c-.804-.0002-1.4559.6515-1.4561 1.4555v.0006l4.9963-.0001a.6157.6157 0 0 1 .6201.591.6064.6064 0 0 1-.5894.6229l-.0159.0002h-3.185c-1.0725.0004-1.9417.8701-1.9413 1.9426v2.185h5.4523l.7727-1.4566h-4.7014v-.5841a.63.63 0 0 1 .6299-.6302z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
