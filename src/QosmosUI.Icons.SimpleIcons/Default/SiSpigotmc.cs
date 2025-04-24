// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiSpigotmc : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.644 2.44c-.179.033-.456.182-.603.331-.245.2-.588.232-2.023.133l-1.713-.116.049.713.049.713h.652c.36-.016 1.207-.05 1.876-.083l1.224-.083v3.317l-.44.05c-.425.05-.457.1-.457.862 0 .713-.05.813-.36.863-.26.033-.39.182-.44.464-.016.232-.114.448-.18.497-.08.05-.228.597-.326 1.211-.228 1.526-.375 1.708-1.37 1.84-1.436.167-2.056.134-2.056-.148 0-.2-.244-.25-1.158-.25-1.012 0-1.158-.032-1.24-.33-.065-.25-.228-.333-.62-.333s-.555.083-.62.332c-.082.299-.228.332-1.224.332-1.011 0-1.158.033-1.256.332-.049.182-.18.331-.26.331-.082 0-.148.863-.148 1.99 0 1.609.05 1.99.229 1.99.13 0 .293.15.342.332.082.282.245.332 1.175.332.914 0 1.077.05 1.142.331.13.465 1.11.465 1.24 0 .065-.282.228-.331 1.158-.331.849 0 1.077-.05 1.077-.25 0-.397 2.121-.33 3.426.117 1.583.53 5.14.53 6.82 0 .653-.199 1.256-.332 1.338-.282.359.232.163.896-.343 1.178-.587.298-.587.563 0 1.956l.343.797 1.599-.067c1.73-.083 2.822-.48 3.915-1.41l.539-.464-.31-.912c-.327-.962-.734-1.327-1.518-1.327-.342 0-.473-.149-.766-.796-.506-1.144-1.224-1.758-2.758-2.355-.799-.315-1.582-.746-1.99-1.127-.604-.548-.685-.73-.832-1.775-.098-.63-.245-1.194-.326-1.244-.066-.05-.164-.265-.18-.497-.049-.282-.18-.431-.424-.464-.326-.05-.375-.15-.375-.863 0-.763-.033-.812-.44-.862-.458-.05-.458-.05-.507-1.526-.032-.929.017-1.542.13-1.658.115-.116.93-.183 2.09-.183h1.908l.05-.564c.032-.298-.017-.63-.099-.713-.098-.1-.816-.083-1.909.05-1.256.15-1.778.15-1.86.017-.146-.25-.848-.481-1.24-.398z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
